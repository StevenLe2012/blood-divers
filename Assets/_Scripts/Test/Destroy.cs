using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        print("Destroyed");
    }

    // private void OnTriggerEnter(Collider other)
    // {
    //     Destroy(other.gameObject);
    // }
}
