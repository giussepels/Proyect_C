using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslocationBall : MonoBehaviour {
	public float initialForce;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody>().AddForce(transform.forward * initialForce, ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
