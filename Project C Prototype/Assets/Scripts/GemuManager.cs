using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemuManager : MonoBehaviour {
	public static bool gameEnd = false;
	public static bool canShoot = true;

	// Use this for initialization
	void Awake () {
		gameEnd = false;
		canShoot = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
