using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellReplacement : MonoBehaviour
{
    [SerializeField] private GameObject brokenCell;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "cell") {
            Destroy(collision.gameObject);
            brokenCell.GetComponent<SkinnedMeshRenderer>().enabled = true;
        }
    }
}
