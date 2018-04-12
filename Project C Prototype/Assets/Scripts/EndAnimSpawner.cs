using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndAnimSpawner : MonoBehaviour {

	public GameObject cubePrefab;

	// Use this for initialization
	void Start () {
		InvokeRepeating("SpawnCubes", 0, 0.05f);
	}
	
	// Update is called once per frame
	void SpawnCubes(){
		Instantiate(cubePrefab, new Vector3(Random.Range(-112.14f,-110.8f), transform.position.y, Random.Range(-251.29f,-252.3f)), transform.rotation);
	}
}
