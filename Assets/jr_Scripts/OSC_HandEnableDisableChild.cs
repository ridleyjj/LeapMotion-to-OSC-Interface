using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OSC_HandEnableDisableChild : Leap.Unity.HandEnableDisable
{
    public OSC osc;
    public string handedness;
    private GameManagement gameManager;

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
            OscMessage message0 = new OscMessage();

            message0.address = "/" + handedness + "_Active";
            message0.values.Add(1);
            osc.Send(message0);
            osc.Send(message0, 2);

            gameObject.SetActive(true);
        }
    }

    protected override void HandFinish()
    {
        OscMessage message0 = new OscMessage();

        message0.address = "/" + handedness + "_Active";
        message0.values.Add(0);
        osc.Send(message0);
        osc.Send(message0, 2);

        gameObject.SetActive(false);
    }
}
