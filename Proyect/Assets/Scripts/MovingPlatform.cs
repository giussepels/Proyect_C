using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {

    public Vector3 dir;

    [Range(-1, 1)]
    public float x;

    public float y;
    public float z;
    public float mult;

     void Start()
    {
        mult = 1;
        y = 0;
        z = 1;
    }

    // Update is called once per frame
    void Update ()
    {
        dir = new Vector3(Mathf.Sin(x) * mult, y, z);
        transform.position += dir * Time.deltaTime;

        x += Time.deltaTime;
    }
}
