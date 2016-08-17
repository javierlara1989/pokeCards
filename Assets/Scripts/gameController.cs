using UnityEngine;
using System.Collections;

public class gameController : MonoBehaviour {

	public int state;
	GameObject foco;

	void Start () {
		state = 0;
	}

	void Update () {
		switch (state)
		{
		    case 0:
			gameStart ();
			//Inicio del juego
			//saca 7 cartas cada uno
			//sirven o las cambias
			//moneda
			//turno 1 o 2
			state = 1;
			break;
		    case 1:
			//tu turno
			//es primer turno? state = 0
			//no - saca carta
			//juega (unico paso donde se desbloquean las cartas)
			//fin de turno
			state = 2;
			break;
		    case 2:
			//turno enemigo
			state = 1;
			break;
		    default:
			//hola
			break;
		}
	}

    
	void gameStart() {
		foco = GameObject.Find ("Foco");
		foco.GetComponent<focoController>().turnOnOff();
	}
}
