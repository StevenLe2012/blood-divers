using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using System;
using UnityEngine.Windows;
using System.IO;

public class ReadPort : MonoBehaviour
{   SerialPort sp = new SerialPort("COM3", 9600);
    public int BPM;
    // Start is called before the first frame update
    void Start()
    {
        sp.Open();
        sp.DtrEnable = true;
        sp.RtsEnable = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (sp.IsOpen)
        {
            int BPM_temp = 0;
            for (int i = 0; i < 10; i++)
            {
                BPM_temp += int.Parse(sp.ReadLine());
            }
            BPM_temp /= 10;
            if (BPM_temp > 120)
            {
                BPM = 120;
            }
            else if (BPM_temp < 40)
            {
                BPM = 40;
            }
            else
            {
                BPM = BPM_temp;
            }
            Debug.Log(BPM);
        }
    }
}
