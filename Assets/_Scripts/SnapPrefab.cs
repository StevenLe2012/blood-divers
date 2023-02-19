using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HeadsUpDisplay
{
    public class SnapPrefab : MonoBehaviour
    {
        public GameObject prefabObject;
        public GameObject cameraObject;
        private Vector3 offset = new Vector3(.25f, .1f, .75f);

        // Start is called before the first frame update
        void Start()
        {
            Instantiate(prefabObject, cameraObject.transform);
        }
    }
}


