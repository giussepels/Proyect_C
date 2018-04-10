using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyWall : MonoBehaviour {


    Rigidbody rb;
    public float thrust;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision col)
    {
        
        if (col.gameObject.tag == "StickyWall")
        {
            rb.isKinematic = true;
        }
    }
}
