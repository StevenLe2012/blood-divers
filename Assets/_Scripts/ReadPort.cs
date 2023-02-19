using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using UnityEditor.TerrainTools;

public class ReadPort : MonoBehaviour
{   
    SerialPort sp = new SerialPort("COM4", 9600);
    [HideInInspector]
    public int BPM = 0;
    
    public static ReadPort Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        sp.Open();
        sp.DtrEnable = true;
        sp.RtsEnable = true;
        StartCoroutine(Coroutine());
    }
    
    IEnumerator Coroutine()
    {
        if (sp.IsOpen)
        {
            while (true)
            {
                //Print the time of when the function is first called.
                Debug.Log("Started Coroutine at timestamp : " + Time.time);

                //yield on a new YieldInstruction that waits for 5 seconds.
                yield return new WaitForSeconds(15);
                BPM = int.Parse(sp.ReadLine());
                Debug.Log(BPM);
                //After we have waited 5 seconds print the time again.
                Debug.Log("Finished Coroutine at timestamp : " + Time.time);
            }
        }
        else
        {
            Debug.Log("Did not run: serial port not opened");
        }
    }
    
    public int GetBPM()
    {
        return BPM;
    }
}
