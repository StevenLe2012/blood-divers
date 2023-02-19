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
        private Vector3 offset = new Vector3(0f, -.2f, .3f);

        // Start is called before the first frame update
        void Start()
        {
            GameObject instance = Instantiate(prefabObject, cameraObject.transform);
            instance.transform.position += offset;
        }
    }
}


