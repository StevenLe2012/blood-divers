using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCell : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("red")) {
            Destroy(other.gameObject);
        }
    }
}
