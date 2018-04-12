using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class WallDoor : MonoBehaviour {

	public float duration;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OpenDoor(){
		transform.DORotateQuaternion(Quaternion.Euler(transform.rotation.x, 90, transform.rotation.z), duration);
	}

	public void CloseDoor(){
		transform.DORotateQuaternion(Quaternion.Euler(transform.rotation.x, 0, transform.rotation.z), duration);
	}
}
