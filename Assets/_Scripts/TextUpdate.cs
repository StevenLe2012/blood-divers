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
        void Start()
        {
            textObject = GameObject.Find("HUD-Text");
            textObject.SetActive(true);
            myTxt = textObject.GetComponent<TextMeshProUGUI>();
            string str = "";
            str += "<b>Move your arms in a swimming motion</b>";
            myTxt.text = str;
        }

        // Update is called once per frame
        void Update()
        {
            // 
        }
    }
}

