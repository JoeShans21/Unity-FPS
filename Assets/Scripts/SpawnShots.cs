using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShots : MonoBehaviour {
	public GameObject shot;
	public Transform shotSpawn;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			GameObject newShot = Instantiate (shot, shotSpawn.position, Quaternion.Euler(new Vector3(90, 0, 0)));
			Rigidbody rb = newShot.GetComponent<Rigidbody> ();
			rb.velocity += transform.forward * 50;
			Destroy (newShot, 10);
		}
	}
}
