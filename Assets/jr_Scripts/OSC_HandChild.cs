using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OSC_HandChild : Leap.Unity.CapsuleHand
{
    public OSC osc;
    
    private string handedness;

    // Update is called once per frame
    void Update()
    {
        if (_hand.IsLeft)   handedness = "Left_";
        else                handedness = "Right_";

        sendDataToOSC();
    }

    void sendDataToOSC()
    {
        OscMessage message1 = new OscMessage();

        message1.address = "/" + handedness + "PalmXYZ";
        message1.values.Add(_hand.PalmPosition.x);
        message1.values.Add(_hand.PalmPosition.y);
        message1.values.Add(_hand.PalmPosition.z);
        osc.Send(message1);
        osc.Send(message1, 2);

        OscMessage message2 = new OscMessage();

        message2.address = "/" + handedness + "fingerTip1XYZ";
        message2.values.Add(_spherePositions[3].x);
        message2.values.Add(_spherePositions[3].y);
        message2.values.Add(_spherePositions[3].z);
        osc.Send(message2);
        osc.Send(message2, 2);

        OscMessage message2b = new OscMessage();

        message2b.address = "/" + handedness + "finger1Joint1XYZ";
        message2b.values.Add(_spherePositions[2].x);
        message2b.values.Add(_spherePositions[2].y);
        message2b.values.Add(_spherePositions[2].z);
        osc.Send(message2b);
        osc.Send(message2b, 2);

        OscMessage message2c = new OscMessage();

        message2c.address = "/" + handedness + "finger1Joint2XYZ";
        message2c.values.Add(_spherePositions[1].x);
        message2c.values.Add(_spherePositions[1].y);
        message2c.values.Add(_spherePositions[1].z);
        osc.Send(message2c);
        osc.Send(message2c, 2);

        OscMessage message2d = new OscMessage();

        message2d.address = "/" + handedness + "finger1KnuckleXYZ";
        message2d.values.Add(_spherePositions[0].x);
        message2d.values.Add(_spherePositions[0].y);
        message2d.values.Add(_spherePositions[0].z);
        osc.Send(message2d);
        osc.Send(message2d, 2);

        OscMessage message3 = new OscMessage();

        message3.address = "/" + handedness + "fingerTip2XYZ";
        message3.values.Add(_spherePositions[7].x);
        message3.values.Add(_spherePositions[7].y);
        message3.values.Add(_spherePositions[7].z);
        osc.Send(message3);
        osc.Send(message3, 2);

        OscMessage message3b = new OscMessage();

        message3b.address = "/" + handedness + "finger2Joint1XYZ";
        message3b.values.Add(_spherePositions[6].x);
        message3b.values.Add(_spherePositions[6].y);
        message3b.values.Add(_spherePositions[6].z);
        osc.Send(message3b);
        osc.Send(message3b, 2);

        OscMessage message3c = new OscMessage();

        message3c.address = "/" + handedness + "finger2Joint2XYZ";
        message3c.values.Add(_spherePositions[5].x);
        message3c.values.Add(_spherePositions[5].y);
        message3c.values.Add(_spherePositions[5].z);
        osc.Send(message3c);
        osc.Send(message3c, 2);

        OscMessage message3d = new OscMessage();

        message3d.address = "/" + handedness + "finger2KnuckleXYZ";
        message3d.values.Add(_spherePositions[4].x);
        message3d.values.Add(_spherePositions[4].y);
        message3d.values.Add(_spherePositions[4].z);
        osc.Send(message3d);
        osc.Send(message3d, 2);

        OscMessage message4 = new OscMessage();

        message4.address = "/" + handedness + "fingerTip3XYZ";
        message4.values.Add(_spherePositions[11].x);
        message4.values.Add(_spherePositions[11].y);
        message4.values.Add(_spherePositions[11].z);
        osc.Send(message4);
        osc.Send(message4, 2);

        OscMessage message4b = new OscMessage();

        message4b.address = "/" + handedness + "finger3Joint1XYZ";
        message4b.values.Add(_spherePositions[10].x);
        message4b.values.Add(_spherePositions[10].y);
        message4b.values.Add(_spherePositions[10].z);
        osc.Send(message4b);
        osc.Send(message4b, 2);

        OscMessage message4c = new OscMessage();

        message4c.address = "/" + handedness + "finger3Joint2XYZ";
        message4c.values.Add(_spherePositions[9].x);
        message4c.values.Add(_spherePositions[9].y);
        message4c.values.Add(_spherePositions[9].z);
        osc.Send(message4c);
        osc.Send(message4c, 2);

        OscMessage message4d = new OscMessage();

        message4d.address = "/" + handedness + "finger3KnuckleXYZ";
        message4d.values.Add(_spherePositions[8].x);
        message4d.values.Add(_spherePositions[8].y);
        message4d.values.Add(_spherePositions[8].z);
        osc.Send(message4d);
        osc.Send(message4d, 2);

        OscMessage message5 = new OscMessage();

        message5.address = "/" + handedness + "fingerTip4XYZ";
        message5.values.Add(_spherePositions[15].x);
        message5.values.Add(_spherePositions[15].y);
        message5.values.Add(_spherePositions[15].z);
        osc.Send(message5);
        osc.Send(message5, 2);

        OscMessage message5b = new OscMessage();

        message5b.address = "/" + handedness + "finger4Joint1XYZ";
        message5b.values.Add(_spherePositions[14].x);
        message5b.values.Add(_spherePositions[14].y);
        message5b.values.Add(_spherePositions[14].z);
        osc.Send(message5b);
        osc.Send(message5b, 2);

        OscMessage message5c = new OscMessage();

        message5c.address = "/" + handedness + "finger4Joint2XYZ";
        message5c.values.Add(_spherePositions[13].x);
        message5c.values.Add(_spherePositions[13].y);
        message5c.values.Add(_spherePositions[13].z);
        osc.Send(message5c);
        osc.Send(message5c, 2);

        OscMessage message5d = new OscMessage();

        message5d.address = "/" + handedness + "finger4KnuckleXYZ";
        message5d.values.Add(_spherePositions[12].x);
        message5d.values.Add(_spherePositions[12].y);
        message5d.values.Add(_spherePositions[12].z);
        osc.Send(message5d);
        osc.Send(message5d, 2);

        OscMessage message6 = new OscMessage();

        message6.address = "/" + handedness + "fingerTip5XYZ";
        message6.values.Add(_spherePositions[19].x);
        message6.values.Add(_spherePositions[19].y);
        message6.values.Add(_spherePositions[19].z);
        osc.Send(message6);
        osc.Send(message6, 2);

        OscMessage message6b = new OscMessage();

        message6b.address = "/" + handedness + "finger5Joint1XYZ";
        message6b.values.Add(_spherePositions[18].x);
        message6b.values.Add(_spherePositions[18].y);
        message6b.values.Add(_spherePositions[18].z);
        osc.Send(message6b);
        osc.Send(message6b, 2);

        OscMessage message6c = new OscMessage();

        message6c.address = "/" + handedness + "finger5Joint2XYZ";
        message6c.values.Add(_spherePositions[17].x);
        message6c.values.Add(_spherePositions[17].y);
        message6c.values.Add(_spherePositions[17].z);
        osc.Send(message6c);
        osc.Send(message6c, 2);

        OscMessage message6d = new OscMessage();

        message6d.address = "/" + handedness + "finger5KnuckleXYZ";
        message6d.values.Add(_spherePositions[16].x);
        message6d.values.Add(_spherePositions[16].y);
        message6d.values.Add(_spherePositions[16].z);
        osc.Send(message6d);
        osc.Send(message6d, 2);

        OscMessage message7 = new OscMessage();

        message7.address = "/" + handedness + "PalmVelocityXYZ";
        message7.values.Add(_hand.PalmVelocity.x);
        message7.values.Add(_hand.PalmVelocity.y);
        message7.values.Add(_hand.PalmVelocity.z);
        osc.Send(message7);
        osc.Send(message7, 2);

        OscMessage message8 = new OscMessage();

        message8.address = "/" + handedness + "RotationXYZW";
        message8.values.Add(_hand.Rotation.x);
        message8.values.Add(_hand.Rotation.y);
        message8.values.Add(_hand.Rotation.z);
        message8.values.Add(_hand.Rotation.w);
        osc.Send(message8);
        osc.Send(message8, 2);

        OscMessage message9 = new OscMessage();

        message9.address = "/" + handedness + "Pinch_Strength_Distance";
        message9.values.Add(_hand.PinchStrength);
        message9.values.Add(_hand.PinchDistance);
        osc.Send(message9);
        osc.Send(message9, 2);

        OscMessage message11 = new OscMessage();

        message11.address = "/" + handedness + "TimeVisible";
        message11.values.Add(_hand.TimeVisible);
        osc.Send(message11);
        osc.Send(message11, 2);
    }
}
