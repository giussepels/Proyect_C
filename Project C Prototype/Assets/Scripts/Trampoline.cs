using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour {

    Rigidbody rb;
    public float thrust;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Trampoline")
        {
            rb.AddForce(transform.up * thrust);
        }
    }
}
