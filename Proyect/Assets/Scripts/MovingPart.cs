using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MovingPart : MonoBehaviour {
	public bool isCeilling;
	Vector3 playerPos;

	// Use this for initialization
	void Start () {
		playerPos = new Vector3 (34, 2, -146);
	}
	
	// Update is called once per frame
	void Update () {
		if (GemuManager.gameEnd == true){
			if (!isCeilling){
			//transform.Translate (playerPos * speed);
			transform.DOMove(playerPos, 20f);
			Quaternion newQuat = Quaternion.Euler(Random.Range(0,360),Random.Range(0,360),Random.Range(0,360) );
			transform.DORotateQuaternion(newQuat, 20f);
			} else{
				Destroy(this.gameObject);
			}
		}
	}
}
