using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotDestroy : MonoBehaviour {

	void OnCollisionEnter(Collision col) {
		Destroy (this.gameObject);
		Debug.Log (GetComponent<Collider>().name);
	}
}
