using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForCamera : MonoBehaviour
{
    public Leap.Unity.LeapServiceProvider Provider;
    private bool connected;
    private GameObject errorMessage;
    private bool ErrorGiven = false;

    void Awake()
    {
        errorMessage = GameObject.FindGameObjectWithTag("CameraError");
        if(Provider.IsConnected())
        {
            errorMessage.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        connected = Provider.IsConnected();

        if (!errorMessage.activeInHierarchy)
        {
            if (!connected && !ErrorGiven)
            {
                errorMessage.SetActive(true);
                ErrorGiven = true;
            }

            if (ErrorGiven && connected)
            {
                ErrorGiven = false;
            }

        }
        else
        {
            if (connected)
            {
                errorMessage.SetActive(false);
                ErrorGiven = false;
            }
        }
    }
}
