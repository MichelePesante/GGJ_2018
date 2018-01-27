using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HackerButton : MonoBehaviour {

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider other) {
		if (other.tag == "Player")
			rb.AddForce(Vector3.forward * 0.1f);
	}
}
