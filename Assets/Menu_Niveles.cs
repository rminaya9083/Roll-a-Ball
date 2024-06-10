using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Niveles : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void Menu_Nivel(string niveles)
	{
		SceneManager.LoadScene ("niveles");
	}


	public void Menu()
	{
		SceneManager.LoadScene("Menu");
	}

	public void NivelJeugo()
	{
		SceneManager.LoadScene("Juego");
	}


	public void Nivel2()
	{
		SceneManager.LoadScene("Nivel-2");
	}

	public void Nivel3()
	{
		SceneManager.LoadScene("Nivel - 3");
	}


	public void Nivel4()
	{
		SceneManager.LoadScene("Nivel - 4");
	}

	public void Nivel5()
	{
		SceneManager.LoadScene("Nivel - 5");
	}


	public void Nivel6()
	{
		SceneManager.LoadScene("Nivel - 6");
	}


}
