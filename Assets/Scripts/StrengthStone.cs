using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class StrengthStone : MonoBehaviour {

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (CrossPlatformInputManager.GetButton("Strength")) {
			transform.parent = null;
		}

		if (CrossPlatformInputManager.GetButton("StrengthJoy")) {
			transform.parent = null;
		}
	}

	void OnTriggerEnter (Collider other) {
		if (other.tag == "Strength") {
			transform.parent = other.transform;
		}
	}
}
