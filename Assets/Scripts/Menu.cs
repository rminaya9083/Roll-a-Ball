using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

	public void EscenaJuego()
	{
		SceneManager.LoadScene ("Juego");
	}

	public void Salir() {
		#if UNITY_EDITOR
		// Si estamos en el editor, se detiene la reproducción del juego
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		// Si estamos en una compilación, se cierra la aplicación
		Application.Quit();
		#endif
	}

	public void Menu_Niveles(string niveles)
	{
		SceneManager.LoadScene ("niveles");
	}

	public void Controller()
	{
		SceneManager.LoadScene ("Cotroler");
	}


}