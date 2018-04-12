using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {

    public GameObject platform;

    public int intelligence = 0;

    private bool isOn = false;
    public bool active = false;



    void Update() {

        if (isOn == false)
        {
            intelligence = 0;
        }
        if (isOn == true)
        {
            intelligence = 1;
        }
        
        if (active == true)
        {

        if (Input.GetKeyDown(KeyCode.E))
        {
            isOn = !isOn;
        }

        }

        Greet();

    }

    void OnTriggerStay(Collider col)
    {
      if (col.gameObject.tag == "Player")
        {
            active = true;
            Debug.Log("Player");
         }
      
    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            active = false;
            Debug.Log("Player");
        }

    }

    void Greet()
    {
        switch (intelligence)
        {
            case 1:
                Debug.Log("PlatformOn");
                platform.GetComponent<MovingPlatform>().enabled = true;
                break;
            default:
                Debug.Log("PlatformOff");
                platform.GetComponent<MovingPlatform>().enabled = false;
                break;
        }
    }

}
