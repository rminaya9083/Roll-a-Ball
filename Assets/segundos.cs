using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class segundos : MonoBehaviour {

	public float tiempo;

	// Use this for initialization
	void Start () {
		tiempo = 5;
	}
	
	// Update is called once per frame
	void Update () {
		tiempo -= Time.deltaTime;

		if (tiempo < 0) {
			SceneManager.LoadScene ("Menu");
		}
	}
}
