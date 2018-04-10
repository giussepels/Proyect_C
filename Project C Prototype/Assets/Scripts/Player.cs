using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;
using UnityStandardAssets.Characters.FirstPerson;

public class Player : MonoBehaviour {

	public GameObject fadePurple;
	public GameObject translocatorGUI;
	public GameObject dialogBox;
	public GameObject fadeToBlack;
	public AudioClip translocateClip;
	public AudioClip crescendoClip;
	public AudioClip dropClip;
	public AudioSource audioS;

	// Use this for initialization
	void Start () {
		GemuManager.gameEnd = false;
		GetComponent<FirstPersonController>().m_WalkSpeed = 5;
	}
	
	// Update is called once per frame
	void Update () {

		if (GameObject.FindWithTag("TBall") != null){
			translocatorGUI.SetActive(true);
		} else{
			translocatorGUI.SetActive(false);
		}


		if(Input.GetMouseButtonDown(1)){
			Destroy(GameObject.FindWithTag("TBall"));
		}

		if (Input.GetKeyDown(KeyCode.E) && GameObject.FindWithTag("TBall") != null){
			fadePurple.GetComponent<Animator>().SetTrigger("PurpleFade");
			GameObject ballLocation = GameObject.FindWithTag("TBall");
			transform.position = ballLocation.transform.position;
			audioS.PlayOneShot(translocateClip);
			Destroy(GameObject.FindWithTag("TBall"));
		}

		if (Input.GetKeyDown(KeyCode.Escape)){
			SceneManager.LoadScene(0);
			//Application.Quit();
		}


		if (transform.position.y < -12){
			fadePurple.GetComponent<Animator>().SetTrigger("PurpleFade");
			Destroy(GameObject.FindWithTag("TBall"));
			transform.position = new Vector3 (-0.52f, 1.04f, -32.76f);
		}
	}

	void OnTriggerEnter(Collider col){
		if (col.tag == "EndTrigger"){
			GetComponent<FirstPersonController>().m_WalkSpeed = 0;
			GetComponent<AudioSource>().volume = 0;
			GemuManager.gameEnd = true;
			GameObject musicManager;
			musicManager = GameObject.Find("MusicManager");
			musicManager.GetComponent<AudioSource>().volume = 0;
			Invoke ("PlayCrescendo", 4.5f);
			Invoke ("FadeToBlack", 10f);
			Invoke ("ShowDialog4", 14f);
			Invoke ("PlayBassDrop", 14f);
			Invoke ("EndGame", 22f);
		}

		if (col.tag == "DialogTrigger1"){
			ShowDialog1();
			Destroy(col.gameObject);
		}

		if (col.tag == "DialogTrigger2"){
			ShowDialog2();
			Destroy(col.gameObject);
		}

		if (col.tag == "DialogTrigger3"){
			ShowDialog3();
			Destroy(col.gameObject);
		}

		if (col.name == "MusicDoorOut"){
			GameObject musicManager = GameObject.Find("MusicManager");
			GetComponent<AudioSource>().DOPitch(1f, 0.5f);
			musicManager.GetComponent<AudioSource>().DOPitch(1f, 0.5f);
		}

		if (col.name == "MusicDoorIn"){
			GameObject musicManager = GameObject.Find("MusicManager");
			GetComponent<AudioSource>().DOPitch(0.2f, 0.5f);
			musicManager.GetComponent<AudioSource>().DOPitch(0.2f, 0.5f);
		}

	}

	void PlayCrescendo(){
		audioS.PlayOneShot(crescendoClip);
	}

	void PlayBassDrop(){
		audioS.PlayOneShot(dropClip);
	}

	void ShowDialog1(){
		dialogBox.GetComponent<Text>().text = "You believe yourselves a superior race because you can manipulate everything that you create...";
		dialogBox.GetComponent<Animator>().SetTrigger("DialogShow");
	}

	void ShowDialog2(){
		dialogBox.GetComponent<Text>().text = "Always trying to find a solution to your lives, always managing to survive...";
		dialogBox.GetComponent<Animator>().SetTrigger("DialogShow");
	}

	void ShowDialog3(){
		dialogBox.GetComponent<Text>().text = "What happens if I told you that is so easy to manipulate all of your SENSES?";
		dialogBox.GetComponent<Animator>().SetTrigger("DialogShow");
	}

	void ShowDialog4(){
		dialogBox.GetComponent<Text>().text = "What happens if I told you that everything you know, is just a LIE?...";
		dialogBox.GetComponent<Animator>().SetTrigger("DialogShow");
	}

	void FadeToBlack(){
		fadeToBlack.SetActive(true);
	}

	void EndGame(){
		SceneManager.LoadScene("MainMenu");
	}
}
