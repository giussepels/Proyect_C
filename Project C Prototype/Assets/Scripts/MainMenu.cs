using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class MainMenu : MonoBehaviour {

	public GameObject fadedBlack;
	private bool isStarting;
	

	void Awake() {
		isStarting = false;
	}

	void Update () {
		if (Input.GetKeyDown(KeyCode.Return) && isStarting == false){
			fadedBlack.SetActive(true);
			//VolumeDownMusic();
			Invoke("VolumeDownMusic", 5f);
			Invoke("StartGemu", 11f);
			isStarting = true;
		}

		if (Input.GetKeyDown(KeyCode.Escape)){
			Application.Quit();
		}
	}

	void StartGemu() {
		SceneManager.LoadScene("Gemu");
	}

	void VolumeDownMusic(){
		GameObject musicManager = GameObject.Find("MusicManager");
		musicManager.GetComponent<AudioSource>().DOFade(0,5f);
	}
}
