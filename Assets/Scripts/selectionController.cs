using UnityEngine;
using System.Collections;

public class selectionController : MonoBehaviour {

	public int option;
	public GameObject vine;
	public GameObject camara;
	void Start () {
		vine = GameObject.Find("Pokeball");
		camara = GameObject.Find("mainCamara");
	}

	void OnMouseOver() {
		vine.transform.localPosition = new Vector3(transform.position.x - 0.6f, transform.position.y - 0.3f, transform.position.z);
	}

	void OnMouseDown() {
		switch (option) {
			case 0:
				Application.LoadLevel("GameScene");
				break;
			case 1:
				camara.transform.localPosition = new Vector3(camara.transform.position.x + 30f, camara.transform.position.y, camara.transform.position.z);
				break;
			case 2:
				Application.Quit();
				break;
			case 3:
				camara.transform.localPosition = new Vector3(camara.transform.position.x - 30f, camara.transform.position.y, camara.transform.position.z);
				break;
			default:
				break;
		}
	}
}
