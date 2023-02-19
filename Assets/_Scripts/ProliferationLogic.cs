using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Cells
{
    public class ProliferationLogic : MonoBehaviour
    {
        // Start is called before the first frame update
        public GameObject CellOriginal;
        public List<GameObject> CellList = new List<GameObject>();
        public bool oneHand = false;
        public bool twoHand = false;
        void Start()
        {
            //GameObject CellClone = Instantiate(CellOriginal);
            //CellList.Add(CellClone);
        }

        // Update is called once per frame
        void Update()
        {
            // if (
        }
    }
}


