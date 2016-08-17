using UnityEngine;
using System.Collections;

public class focoController : MonoBehaviour {

	Light priLight;

	void Start () {
		priLight = GetComponent<Light>();
	}

	void Update () {

	}

	void lightHit () {

	}

	public void turnOnOff () {
		if (priLight.enabled == true) {
			priLight.enabled = false;
		} else {
			priLight.enabled = true;
		}
	}
}
