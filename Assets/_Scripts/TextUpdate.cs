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
            yield return new WaitForSecondsRealtime(5);
            str = "<b>Look at that! The cell split! In fact it can keep spliting!</b>";
            myTxt.text = str;
            yield return new WaitForSecondsRealtime(6);
            str = "<b>These cells can aid the internally ruptured blood vessel, and you can help!</b>";
            myTxt.text = str;
            yield return new WaitForSecondsRealtime(7);
            str = "<b>Grab your cell and drag it into the rupture</b>";
            myTxt.text = str;
            yield return new WaitForSecondsRealtime(8);
            str = "<b>A portion of the endothelial monolayer should have recovered!</b>";
            myTxt.text = str;
            yield return new WaitForSecondsRealtime(5);
            str = "<b>Keep adding endothelial cells to speed up the healing</b>";
            myTxt.text = str;
            yield return new WaitForSecondsRealtime(5);
            str = "<b>Feel free to look around as you finish</b>";
            myTxt.text = str;
            yield return new WaitForSecondsRealtime(15);
            str = "<b>You may notice other cells moving faster or slower</b>";
            myTxt.text = str;
            yield return new WaitForSecondsRealtime(6);
            str = "<b>You will probably recognize the red blood cell!</b>";
            myTxt.text = str;
            yield return new WaitForSecondsRealtime(5);
            str = "<b>It makes up around 45% of your blood!</b>";
            myTxt.text = str;
            yield return new WaitForSecondsRealtime(5);
            str = "<b>Essentially the remaining 55% of your blood is plasma!</b>";
            myTxt.text = str;
            yield return new WaitForSecondsRealtime(7);
            str = "<b>If you're lucky, you may spot something rare</b>";
            myTxt.text = str;
            yield return new WaitForSecondsRealtime(6);
            str = "<b>1% of your blood is white blood cells!</b>";
            myTxt.text = str;
            yield return new WaitForSecondsRealtime(5);
            str = "<b>And less than 1% consists platelet</b>";
            myTxt.text = str;
            yield return new WaitForSecondsRealtime(5);
        }
    }
}

