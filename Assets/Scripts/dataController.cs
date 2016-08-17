using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class dataController : MonoBehaviour {

	public static string deckCards;

	void Start (){
		deckCards = loadResourceTextfile("deckCards");
		JSONObject jsonDeckCards = new JSONObject(deckCards);
	}

	public static string loadResourceTextfile(string path) {
		TextAsset targetFile = Resources.Load<TextAsset>(path);
		return targetFile.text;
	}

}
