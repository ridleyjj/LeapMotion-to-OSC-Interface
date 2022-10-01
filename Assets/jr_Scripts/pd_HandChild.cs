using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pd_HandChild : Leap.Unity.CapsuleHand
{

    public LibPdInstance pdPatch;

    private string handedness;

    // Update is called once per frame
    void Update()
    {
        if (_hand.IsLeft)   handedness = "Left_";
        else                handedness = "Right_";

        sendDataToPd();
    }

    void sendDataToPd()
    {
        pdPatch.SendFloat(handedness + "PalmX", _hand.PalmPosition.x);
        pdPatch.SendFloat(handedness + "PalmY", _hand.PalmPosition.y);
        pdPatch.SendFloat(handedness + "PalmZ", _hand.PalmPosition.z);
        
        pdPatch.SendFloat(handedness + "FT1X", _spherePositions[3].x);
        pdPatch.SendFloat(handedness + "FT1Y", _spherePositions[3].y);
        pdPatch.SendFloat(handedness + "FT1Z", _spherePositions[3].z);

        pdPatch.SendFloat(handedness + "FT2X", _spherePositions[7].x);
        pdPatch.SendFloat(handedness + "FT2Y", _spherePositions[7].y);
        pdPatch.SendFloat(handedness + "FT2Z", _spherePositions[7].z);

        pdPatch.SendFloat(handedness + "FT3X", _spherePositions[11].x);
        pdPatch.SendFloat(handedness + "FT3Y", _spherePositions[11].y);
        pdPatch.SendFloat(handedness + "FT3Z", _spherePositions[11].z);

        pdPatch.SendFloat(handedness + "FT4X", _spherePositions[15].x);
        pdPatch.SendFloat(handedness + "FT4Y", _spherePositions[15].y);
        pdPatch.SendFloat(handedness + "FT4Z", _spherePositions[15].z);
        
        pdPatch.SendFloat(handedness + "FT5X", _spherePositions[19].x);
        pdPatch.SendFloat(handedness + "FT5Y", _spherePositions[19].y);
        pdPatch.SendFloat(handedness + "FT5Z", _spherePositions[19].z);
        
        pdPatch.SendFloat(handedness + "PVX", _hand.PalmVelocity.x);
        pdPatch.SendFloat(handedness + "PVY", _hand.PalmVelocity.y);
        pdPatch.SendFloat(handedness + "PVZ", _hand.PalmVelocity.z);

        pdPatch.SendFloat(handedness + "RotX", _hand.Rotation.x);
        pdPatch.SendFloat(handedness + "RotY", _hand.Rotation.y);
        pdPatch.SendFloat(handedness + "RotZ", _hand.Rotation.z);
        pdPatch.SendFloat(handedness + "RotW", _hand.Rotation.w);
        
        pdPatch.SendFloat(handedness + "PinchStr", _hand.PinchStrength);
        pdPatch.SendFloat(handedness + "PinchDist", _hand.PinchDistance);

        pdPatch.SendFloat(handedness + "Time", _hand.TimeVisible);
    }
}
