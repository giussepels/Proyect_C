using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ElevatorPlat : MonoBehaviour {

	public bool isGoingUp;
	// public int state;
	public float upPos;
	public float downPos;
	public float duration;
	private Rigidbody rb;

	void Awake(){
		isGoingUp = true;
		rb = GetComponent<Rigidbody>();
	}

	void Start () {
		GoingUp();
	}
	
	void Update () {
		// switch(state){ // States: 1 = Up, 2 = Down, 3 = Still
		// 	case 1:
		// 		rb.DOMoveY(upPos, duration);
		// 	break;
		// 	case 2:
		// 		rb.DOMoveY(downPos, duration);
		// 	break;
		// }

		// if (Input.GetKeyDown(KeyCode.I)){
		// 	GoingUp();
		// 	Debug.Log("Calling Going Up");
		// }
		// if (Input.GetKeyDown(KeyCode.K)){
		// 	GoingDown();
		// 	Debug.Log("Calling Going Down");
		// }
	}

	public void GoingUp(){
		rb.DOMoveY(upPos, duration);
	}

	public void GoingDown(){
		rb.DOMoveY(downPos, 1f);
	}
}
