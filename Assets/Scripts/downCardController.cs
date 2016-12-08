using UnityEngine;
using System.Collections;

public class downCardController : MonoBehaviour {

	bool visible;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		visible = gameObject.GetComponent<Renderer> ().enabled;
	}

	public void gone(){
		gameObject.GetComponent<Renderer> ().enabled = false;
	}

	public void appear(){
		gameObject.GetComponent<Renderer> ().enabled = true;
	}

	void OnMouseDown(){
		if (!visible) {
			appear ();
		} else {
			gone ();
		}
	}
}
