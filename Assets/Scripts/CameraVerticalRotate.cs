using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraVerticalRotate : MonoBehaviour {

	public float rotationSpeed = 10;
	public float maxRotation = 0.45f;
	public float minRotation = -0.45f;
	public float xRotation;
	public float mouseInput;
	public bool reachedMax = false, reachedMin = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		WithinBoundary ();
		mouseInput = Input.GetAxis ("Mouse Y");
		if (!reachedMax && !reachedMin) {
			transform.Rotate (mouseInput * rotationSpeed, 0, 0);
		} else if (reachedMax) {
			if (mouseInput < 0) {
				transform.Rotate (mouseInput * rotationSpeed, 0, 0);
			}
		}
		else if (reachedMin){
			if (mouseInput > 0) {
				transform.Rotate (mouseInput * rotationSpeed, 0, 0);
			}
		}
	}
	private void WithinBoundary(){
		xRotation = transform.localRotation.x;
		reachedMax = xRotation > maxRotation;
		reachedMin = xRotation < minRotation;
	}
}
