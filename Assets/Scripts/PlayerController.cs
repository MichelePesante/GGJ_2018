using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public KeyCode hackerButton;
	public KeyCode jumpButton;
	public KeyCode speedButton;
	public KeyCode strengthButton;
	public KeyCode triggerButton;

	public Abilities playerAbilities;

	void Start () {
		playerAbilities = GameObject.FindObjectOfType<Abilities> ();
	}

	void Update () {
		if (this.gameObject.name == "Player1") {
			if (Input.GetKey(hackerButton) && Input.GetKey(triggerButton)) {
				playerAbilities.SendAb ("Hacker", 2);
			}

			if (Input.GetKey(jumpButton) && Input.GetKey(triggerButton)) {
				playerAbilities.SendAb ("Jump", 2);
			}

			if (Input.GetKey(speedButton) && Input.GetKey(triggerButton)) {
				playerAbilities.SendAb ("Speed", 2);
			}

			if (Input.GetKey(strengthButton) && Input.GetKey(triggerButton)) {
				playerAbilities.SendAb ("Strength", 2);
			}
				
			if (Input.GetKeyDown(hackerButton) && PlayerPrefs.GetInt("HackerP1") == 1) {
				this.gameObject.GetComponent<SphereCollider>().enabled = true;
			}

			if (Input.GetKeyUp(hackerButton) && PlayerPrefs.GetInt("HackerP1") == 1) {
				this.gameObject.GetComponent<SphereCollider>().enabled = false;
			}
		}

		if (this.gameObject.name == "Player2") {
			if (Input.GetKey(hackerButton) && Input.GetKey(triggerButton)) {
				playerAbilities.SendAb ("Hacker", 1);
			}

			if (Input.GetKey(jumpButton) && Input.GetKey(triggerButton)) {
				playerAbilities.SendAb ("Jump", 1);
			}

			if (Input.GetKey(speedButton) && Input.GetKey(triggerButton)) {
				playerAbilities.SendAb ("Speed", 1);
			}

			if (Input.GetKey(strengthButton) && Input.GetKey(triggerButton)) {
				playerAbilities.SendAb ("Strength", 1);
			}

			if (Input.GetKeyDown(hackerButton) && PlayerPrefs.GetInt("HackerP2") == 1) {
				this.gameObject.GetComponent<SphereCollider>().enabled = true;
			}

			if (Input.GetKeyUp(hackerButton) && PlayerPrefs.GetInt("HackerP2") == 1) {
				this.gameObject.GetComponent<SphereCollider>().enabled = false;
			}
		}
	}
}
