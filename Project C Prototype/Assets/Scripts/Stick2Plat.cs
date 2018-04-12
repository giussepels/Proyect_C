using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick2Plat : MonoBehaviour {

	void OnTriggerEnter(Collider col){
		if (col.tag == "Player"){
			col.transform.SetParent(transform);
		}
	}

	void OnTriggerExit(Collider col){
		if (col.tag == "Player"){
			col.transform.SetParent(null);
		}
	}
}
