using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pd_HandEnableDisableChild : Leap.Unity.HandEnableDisable
{
    public string handedness;
    private GameManagement gameManager;
    public LibPdInstance pdPatch;

    protected override void Awake()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManagement>();

        // Suppress Warnings Related to Kinematic Rigidbodies not supporting Continuous Collision Detection
#if UNITY_2018_3_OR_NEWER
        Rigidbody[] bodies = GetComponentsInChildren<Rigidbody>();
        foreach (Rigidbody body in bodies)
        {
            if (body.isKinematic && body.collisionDetectionMode == CollisionDetectionMode.Continuous)
            {
                body.collisionDetectionMode = CollisionDetectionMode.ContinuousSpeculative;
            }
        }
#endif

        base.Awake();
    }
    protected override void HandReset()
    {
        if(!gameManager.isPaused)
        {
            pdPatch.SendFloat(handedness + "_Active", 1);

            gameObject.SetActive(true);
        }
    }

    protected override void HandFinish()
    {
        pdPatch.SendFloat(handedness + "_Active", 0);

        gameObject.SetActive(false);
    }
}
