using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class WallDoor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OpenDoor(){
		Debug.Log("Open Door");
		transform.DORotateQuaternion(Quaternion.Euler(transform.rotation.x, 90, transform.rotation.z), 0.6f);
	}

	public void CloseDoor(){
		Debug.Log("Close Door");
		transform.DORotateQuaternion(Quaternion.Euler(transform.rotation.x, 0, transform.rotation.z), 0.6f);
	}
}
