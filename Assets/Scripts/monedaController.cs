using UnityEngine;
using System.Collections;

public class monedaController : MonoBehaviour {

	public static Rigidbody rb;
	public static float force;
	public float turnForce;
	public static int result;
	public static bool threw;
	public float moving;

	void Start () {
		rb = GetComponent<Rigidbody>();
		force = Random.Range(15.0f, 25.0f);
		turnForce = Random.Range(280.0f, 380.0f);
	}

	void Update () {
		moving = rb.velocity.magnitude;
		if (!isGrounded()) {
			//start turning
			threw = true;
			transform.Rotate(Vector3.right * Time.deltaTime * turnForce);
		}
		if (threw && moving == 0) {
			//get result
			result = getResult();
		}
	}

	int getResult() {
		if (transform.eulerAngles.z < 20) {
			return 0;
		} else {
			return 1;
		}
	}

	bool isGrounded() {
		if (transform.localPosition.y < -1.45) {
			return true;
		}
		return false;
	}

	public static void throwCoin() {
		result = -1;
		threw = false;
		rb.AddForce(0, force, 0, ForceMode.Impulse);
	}	

	void OnMouseDown(){
		throwCoin();
	}
}
