using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

	public float speed = 20;
	public float rotationSpeed = 10;

	void Start () {

	}

	void FixedUpdate () {
		if (Input.GetKey(KeyCode.W)){
			transform.Translate (Vector3.forward * speed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.A)){
			transform.Translate (Vector3.left * speed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.S)){
			transform.Translate (Vector3.back * speed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.D)){
			transform.Translate (Vector3.right * speed * Time.deltaTime);
		}
		transform.Rotate (0, Input.GetAxis("Mouse X") * rotationSpeed, 0);

	}
}