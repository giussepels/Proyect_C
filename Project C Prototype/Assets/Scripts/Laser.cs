using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {

    LineRenderer laser;
    public float laserActive;
    public float t;
    bool activate;

	void Start ()
    {
        activate = false;
        gameObject.GetComponent<Light>().enabled = false;
        laser = gameObject.GetComponent<LineRenderer>();
        laser.enabled = false;
	}

	void Update ()
    {
        if (activate == false)
        {
            t += Time.deltaTime;
        }

        if (activate == true)
        {
            t -= Time.deltaTime;
        }

        if (t >= laserActive)
        {
            activate = true;
        }
        if (t <= 0)
        {
            activate = false;
        }

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
                    Destroy(hit.transform.gameObject);
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