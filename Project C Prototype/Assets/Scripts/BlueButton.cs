using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueButton : MonoBehaviour {

    public GameObject platform;


    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            platform.GetComponent<MovingPlatform>().enabled = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            platform.GetComponent<MovingPlatform>().enabled = false;
        }

    }
}
