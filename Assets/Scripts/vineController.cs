using UnityEngine;
using System.Collections;

public class vineController : MonoBehaviour {

	float xRotationSpeed;
	float yRotationSpeed;

	void Start () {
		xRotationSpeed = 130f;
		yRotationSpeed = 130f;
	}
	
	void Update () {
		transform.Rotate(Vector3.right * yRotationSpeed * Time.deltaTime);
		//transform.Rotate(Vector3.up * xRotationSpeed * Time.deltaTime);
	}
}
