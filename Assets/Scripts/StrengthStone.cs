using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrengthStone : MonoBehaviour {

	private Rigidbody rb;
	private PlayerController pc;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		pc = GameObject.FindObjectOfType<PlayerController> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (pc.strengthButton)) {
			transform.parent = null;
		}
	}

	void OnTriggerEnter (Collider other) {
		if (other.tag == "Strength") {
			transform.parent = other.transform;
		}
	}
}
