using UnityEngine;
using System.Collections;

public class mazoController : MonoBehaviour {
	
	float cardSize;
	int deckNumber;
	int[] deckCards = new int[59];

	void Start () {
		cardSize = transform.localScale.y / 60;
		deckNumber = 60;
		deckCards = getDeck();
	}

	void Update () {
	}

	void SacarCarta (int amount) {
        for(int i=0;i<amount;i++){
            transform.localScale += new Vector3(0,-cardSize,0);
        }
		if (transform.localScale.y < cardSize) {
			Destroy (this.gameObject);
		}
	}
    
	void AgregarCarta (int amount) {
        for(int i=0;i<amount;i++){
            transform.localScale += new Vector3(0,+cardSize,0);
        }
		if (transform.localScale.y < cardSize) {
			Destroy (this.gameObject);
		}
	}

	int [] getDeck() {
		int[] deck = new int[59];
		return deck;
	}

	void OnMouseDown(){
		SacarCarta (1);
	}
}
