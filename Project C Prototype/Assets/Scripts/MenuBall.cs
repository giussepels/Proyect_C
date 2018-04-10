using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update (){
    transform.Rotate (0,0,50*Time.deltaTime); //rotates 50 degrees per second around z axis
	transform.Rotate (25*Time.deltaTime,0,0); //rotates 50 degrees per second around z axis
	transform.Rotate (0,10*Time.deltaTime,0); //rotates 50 degrees per second around z axis
}
}
