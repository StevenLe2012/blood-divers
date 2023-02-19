using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellReplacement : MonoBehaviour
{
    [SerializeField] private GameObject brokenCell;

    void OnTriggerEnter(Collider other)
    {
        print("Someone has entered:");
        print(other.gameObject.name);
        if (other.gameObject.CompareTag("cell")) {
            print("Cell Entered");
            Destroy(other.gameObject);
            brokenCell.GetComponent<SkinnedMeshRenderer>().enabled = true;
            Destroy(this.gameObject);
        }
    }
}
