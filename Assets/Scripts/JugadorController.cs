using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Agregamos
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JugadorController : MonoBehaviour {

	//Declado la variable de tipo RigidBody que luego asociaremos a nuestro Jugador
	private Rigidbody rb;

	private int contador;

	public float timer;
	private bool juegoTerminado = false;

	//Declaro la variable pública velocidad para poder modificarla desde la Inspector window
	public float velocidad;

	//Inicializo variables para los textos
	public Text textoContador, textoGanar, textoNombre, textoMatricula, textoTiempo;



	// Use this for initialization
	void Start () {

		//Camputro esa variable al inicializar el juego.
		rb = GetComponent<Rigidbody>();

		//Inicio el contador a 0
		contador = 0;

		//Actualizo el texto del contador por pimera vez
		setTextoContador();

		//Inicio el texto de ganar a vacío
		textoGanar.text = "";

	}




	// Para que se sincronice con los frames de física del motor
	void FixedUpdate () {
		
		if (juegoTerminado) {
			DetenerJuego();
			rb.velocity = Vector3.zero; // Detener el movimiento completamente
			rb.angularVelocity = Vector3.zero; // Detener cualquier rotación
			return; // No ejecutar el código de movimiento si el juego ha terminado
		}

		//Estas variables nos capturan el movimiento en horizontal y vertical de nuestro teclado
		float movimientoH = Input.GetAxis("Horizontal");
		float movimientoV = Input.GetAxis("Vertical");
		//Un vector 3 es un trío de posiciones en el espacio XYZ, en este		caso el que corresponde al movimiento
		Vector3 movimiento = new Vector3(movimientoH, 0.0f,	movimientoV);
		//Asigno ese movimiento o desplazamiento a mi RigidBody
		rb.AddForce(movimiento);

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Coleccionable"))
		{
			//Desactivo el objeto
			other.gameObject.SetActive (false);
			//Incremento el contador en uno (también se peude hacer como contador++)
			contador = contador + 1;

			//Actualizo el texto del contador
			setTextoContador();
		}
	}

	void setTextoContador(){
		textoContador.text = "Contador: " + contador.ToString();
		if (contador == 12){
			textoGanar.text = "¡Ganaste!";
			CargarMenuNivel ();
			juegoTerminado = true;
			DetenerJuego();
		}
	}

	// Update is called once per frame
	void Update () {

		if (timer > 0) {
			timer -= Time.deltaTime;
			textoTiempo.text = "Segundos: " + timer.ToString("f1");
		} else if (timer < 0 && contador < 12) {
			textoGanar.text = "¡Perdiste!";			
			juegoTerminado = true;
			DetenerJuego ();

		}

		//Estas variables nos capturan el movimiento en horizontal y vertical de nuestro teclado o mouse
		float movimientoH = Input.GetAxis("Horizontal");
		float movimientoV = Input.GetAxis("Vertical");

		//Un vector 3 es un trío de posiciones en el espacio XYZ, en este caso el que corresponde al movimiento
		Vector3 movimiento = new Vector3(movimientoH, 0.0f, movimientoV).normalized;

		//Establezco la velocidad directamente al RigidBody, multiplicado por la velocidad que quiera darle
		rb.velocity = movimiento * velocidad;

	}

	void DetenerJuego() {
		rb.velocity = Vector3.zero; // Detener el movimiento completamente
		rb.angularVelocity = Vector3.zero; // Detener cualquier rotación

	}

	void CargarMenuNivel() {
		SceneManager.LoadScene("Niveles");
	}



}
