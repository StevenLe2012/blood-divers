using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using UnityEditor.TerrainTools;

public class ReadPort : MonoBehaviour
{   SerialPort sp = new SerialPort("COM3", 9600);
    public int BPM;
    // Start is called before the first frame update
    void Start()
    {
        sp.Open(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (sp.IsOpen)
        {
            try
            {
                //BPM = Convert.ToInt32(sp.ReadLine());
            }
            catch (System.Exception) {
                Debug.Log("system exception occured");
            }
        }
    }
}
