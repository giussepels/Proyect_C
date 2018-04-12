using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorButton : MonoBehaviour {

	public GameObject elevator;


	void OnTriggerEnter(Collider col){
		if (col.tag == "Player"){
			elevator.GetComponent<ElevatorPlat>().GoingDown();
		}
	}

	void OnTriggerExit(Collider col){
		if (col.tag == "Player"){
			elevator.GetComponent<ElevatorPlat>().GoingUp();
		}
	
	}
}
