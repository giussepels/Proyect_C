using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Level1Manager : MonoBehaviour {


	void Start () {
		GameObject musicManager = GameObject.Find("MusicManager");
		musicManager.GetComponent<AudioSource>().DOPitch(0.2f, 0.5f);
		musicManager.GetComponent<AudioSource>().DOFade(0.4f, 0.5f);
	}

}
