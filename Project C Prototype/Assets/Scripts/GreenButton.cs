using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenButton : MonoBehaviour {

    public GameObject[] PlatformPieces;

 

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            foreach (GameObject obj in PlatformPieces)
            {
                obj.SetActive(false);
            }
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            foreach (GameObject obj in PlatformPieces)
            {
                obj.SetActive(true);
            }
        }

    }
}
