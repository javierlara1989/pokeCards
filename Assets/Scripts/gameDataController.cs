using UnityEngine;
using System.Collections;

public class gameDataController : MonoBehaviour {

	public static int deckNumber;
	public static int activeDeck;
	public static int[][] decks = new int[10][];

	void Start () {
		deckNumber = 2;
		activeDeck = 0;
		decks[0] = new int[] {1, 1, 1, 2, 3, 4, 1, 2, 3, 4, 5, 1, 1, 2, 7, 2};
	}

	void Awake() {
		DontDestroyOnLoad(transform.gameObject);
	}
}
