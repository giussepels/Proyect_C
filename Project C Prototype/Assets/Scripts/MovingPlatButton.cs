using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatButton : MonoBehaviour {

public GameObject movingPlat;

public bool isBackwards;




	void OnTriggerStay(Collider col){
		if (col.tag == "Player"){
			if(isBackwards){
				movingPlat.GetComponent<MovingPlatX>().GoingForward();
			} else {
				movingPlat.GetComponent<MovingPlat>().GoingBack();
			}
		}
	}

	void OnTriggerExit(Collider col){
		if (col.tag == "Player"){
			if(isBackwards){
				movingPlat.GetComponent<MovingPlatX>().GoingBack();
			} else {
				movingPlat.GetComponent<MovingPlat>().GoingForward();
			}
		}
	
	}
}
