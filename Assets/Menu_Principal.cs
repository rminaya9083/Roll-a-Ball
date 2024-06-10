using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Principal : MonoBehaviour {


	public void MenuPrincipal(string nombre)
	{
		SceneManager.LoadScene(nombre);
	}

	// Use this for initialization
	void Start () {

	}

}
