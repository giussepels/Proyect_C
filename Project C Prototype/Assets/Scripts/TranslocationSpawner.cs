using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Utility;
using UnityEngine;

public class TranslocationSpawner : MonoBehaviour {
	public GameObject translocationBallOject;
	//public Camera fpsCamera;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0) && GameObject.FindWithTag("TBall") == null && GemuManager.canShoot){
			Instantiate(translocationBallOject, transform.position,  Camera.main.transform.rotation);
		}
	}
}
