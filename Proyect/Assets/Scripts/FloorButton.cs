using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorButton : MonoBehaviour {

	public GameObject mechanism;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){
		if (col.tag == "Player"){
			mechanism.GetComponent<WallDoor>().OpenDoor();
		}
	}

	void OnTriggerExit(Collider col){
		if (col.tag == "Player"){
			mechanism.GetComponent<WallDoor>().CloseDoor();
		}
	
	}
}
