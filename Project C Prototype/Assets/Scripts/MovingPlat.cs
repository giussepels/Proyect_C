using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MovingPlat : MonoBehaviour {

	bool isGoingForward;
	// int state;
	public float forwardPos;
	public float backPos;
	public float duration;
	private Rigidbody rb;

	void Awake(){
		isGoingForward = true;
		rb = GetComponent<Rigidbody>();
	}

	void Start () {
		GoingForward();
	}
	
	void Update () {
		// switch(state){ // States: 1 = Up, 2 = Down, 3 = Still
		// 	case 1:
		// 		rb.DOMoveX(forwardPos, duration);
		// 	break;
		// 	case 2:
		// 		rb.DOMoveX(initialPos, duration);
		// 	break;
		// }

		if (Input.GetKeyDown(KeyCode.I)){
			GoingForward();
			Debug.Log("Calling Going Up");
		}
		if (Input.GetKeyDown(KeyCode.K)){
			GoingBack();
			Debug.Log("Calling Going Down");
		}
	}

	public void GoingForward(){
		GetComponent<Transform>().DOMoveZ(forwardPos, duration);
	}

	public void GoingBack(){
		//rb.DOMoveZ(backPos, duration);
		GetComponent<Transform>().DOMoveZ(backPos, 2f);
	}
}
