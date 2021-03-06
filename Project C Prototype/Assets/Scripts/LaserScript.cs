﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour {

    LineRenderer laser;
    public bool activate;

	void Start ()
    {
        activate = true;
        gameObject.GetComponent<Light>().enabled = false;
        laser = gameObject.GetComponent<LineRenderer>();
        laser.enabled = false;
	}

	void Update ()
    {
        

        if (activate == true) // Si quieres que sea por tiempo anade un timer y cambia esto
        {
            StopCoroutine("FireLaser");
            StartCoroutine("FireLaser");

        }
	}

    IEnumerator FireLaser()
    {
        laser.enabled = true;
        gameObject.GetComponent<Light>().enabled = true;

        while (activate == true)
        {
            
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;
            laser.SetPosition(0, ray.origin);


            if (Physics.Raycast(ray, out hit, 100))
            {
                laser.SetPosition(1, hit.point);
                if (hit.rigidbody)
                {
                    if (hit.transform.tag == "Player"){
                        hit.transform.gameObject.GetComponent<Player>().Respawn();
                    } else if(hit.transform.tag == "TBall"){
                        Destroy(hit.transform.gameObject);
                    }
                    // hit.rigidbody.AddForceAtPosition(transform.forward * 5, hit.point); Si quieres que el laser empuje algo
                }
            }

            else
                laser.SetPosition(1, ray.GetPoint(100));

   

            yield return null;
        }

        laser.enabled = false;
        gameObject.GetComponent<Light>().enabled = false;
    }

}
