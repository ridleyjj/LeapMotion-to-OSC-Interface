using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangingPorts : MonoBehaviour
{
    public OSC osc;
    public Text newPort1;
    public Text newPort2;
    private int defaultPort1 = 6161;
    private int defaultPort2 = 6448;

    private void Awake()
    {
        //newPort1 = GameObject.FindGameObjectWithTag("InputField1").GetComponent<Text>();
        //newPort2 = GameObject.FindGameObjectWithTag("InputField2").GetComponent<Text>();
    }

    public void SetNewPorts()
    {
        int portNumber1 = defaultPort1;
        int portNumber2 = defaultPort2;
        if(newPort1.text != "")
            portNumber1 = int.Parse(newPort1.text);
        if(newPort2.text != "")
            portNumber2 = int.Parse(newPort2.text);

        osc.SetPorts(portNumber1, portNumber2);
    }
}
