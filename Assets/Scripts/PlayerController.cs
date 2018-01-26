using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public KeyCode hackerButton;
	public KeyCode jumpButton;
	public KeyCode speedButton;
	public KeyCode strengthButton;
	public KeyCode triggerButton;

	public GameObject gc;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (this.gameObject.name == "Player1") {
			if (Input.GetKeyDown(jumpButton) && Input.GetKeyDown(triggerButton)) {
				// SendAb ("Jump", 2);
			}
		}
	}
}
