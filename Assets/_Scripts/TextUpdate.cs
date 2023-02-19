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
            string str = "";
            str += "<b>Welcome to [app name?]</b>";
            myTxt.text = str;
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
                var str = cellCount.ToString();
                myTxt.text = str;
                tempCount = cellCount;
            }
        }
    }
}

