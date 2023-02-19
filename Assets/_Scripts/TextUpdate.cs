using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace HeadsUpDisplay {
    public class TextUpdate : MonoBehaviour
    {
        // Start is called before the first frame update
        private GameObject textObject;
        private TextMeshProUGUI myTxt;
        public GameObject TwoHandObject;
        private TwoHandGrabInteractable TwoHandGrabScript;
        public List<GameObject> cellObjectsUpdated = new List<GameObject>();
        private int tempCount;
        
        void Start()
        {
            // Text Mesh Pro 
            textObject = GameObject.Find("HUD-Text");
            textObject.SetActive(true);
            myTxt = textObject.GetComponent<TextMeshProUGUI>();
            StartCoroutine(TextUpdates());
        }

        // Update is called once per frame
        void Update()
        {
            // Access Two Hand Script
            TwoHandGrabScript = TwoHandObject.GetComponent<TwoHandGrabInteractable>();

            // Access Two Hand Script Cell List
            cellObjectsUpdated = TwoHandGrabScript.cellObjects;
            
            int cellCount = cellObjectsUpdated.Count;

            if (cellCount > tempCount)
            {
                // var str = cellCount.ToString();
                // myTxt.text = str;
                tempCount = cellCount;
            }
        }

        private IEnumerator TextUpdates()
        {
            yield return new WaitForSecondsRealtime(8);
            string str = "";
            str += "<b>Welcome to [app name?]</b>";
            myTxt.text = str;
            yield return new WaitForSecondsRealtime(5);
            str = "<b>Firstly, lets figure out navigation!</b>";
            myTxt.text = str;
            yield return new WaitForSecondsRealtime(5);
            str = "<b>Hold your hands out in front of you and hold down the triggers</b>";
            myTxt.text = str;
            yield return new WaitForSecondsRealtime(8);
            str = "<b>Move your arms back and let go of the triggers</b>";
            myTxt.text = str;
            yield return new WaitForSecondsRealtime(5);
            str = "<b>Repeat this movement to travel across the the blood vessel</b>";
            myTxt.text = str;
            yield return new WaitForSecondsRealtime(5);
            str = "<b>Keep traveling until you reach a breach in the vessel wall!</b>";
            myTxt.text = str;
            yield return new WaitForSecondsRealtime(15);
            str = "<b>Hopefully you've made it by now!</b>";
            myTxt.text = str;
            yield return new WaitForSecondsRealtime(5);
            str = "<b>Here you should see a floating cell</b>";
            myTxt.text = str;
            yield return new WaitForSecondsRealtime(5);
            str = "<b>Grab the cell with your right hand!</b>";
            myTxt.text = str;
            yield return new WaitForSecondsRealtime(5);
            str = "<b>Now also grab the cell with your left hand!</b>";
            myTxt.text = str;
            //yield return new WaitForSecondsRealtime()

        }
    }
}

