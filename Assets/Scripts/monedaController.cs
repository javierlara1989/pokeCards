using UnityEngine;
using System.Collections;

public class monedaController : MonoBehaviour {

	public Rigidbody rb;
	public float force;
	public float turnForce;
	public int result;
	public bool threw;
	public float moving;

	void Start () {
		rb = GetComponent<Rigidbody>();
		force = Random.Range(15.0f, 25.0f);
		turnForce = Random.Range(230.0f, 280.0f);
		threw = false;
		result = -1;
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
    
	void throwCoin() {
		rb.AddForce(0, force, 0, ForceMode.Impulse);
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

	void OnMouseDown(){
		throwCoin();
	}
}
