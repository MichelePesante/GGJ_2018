using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour {

	public Abilities playerAbilities;

	void Start () {
		playerAbilities = GameObject.FindObjectOfType<Abilities> ();
	}

	void Update () {
		if (this.gameObject.name == "Player1") {
			if (CrossPlatformInputManager.GetButton("Hacker") && CrossPlatformInputManager.GetButton("Trigger")) {
				playerAbilities.SendAb ("Hacker", 2);
			}

			if (CrossPlatformInputManager.GetButton("Jump") && CrossPlatformInputManager.GetButton("Trigger")) {
				playerAbilities.SendAb ("Jump", 2);
			}

			if (CrossPlatformInputManager.GetButton("Speed") && CrossPlatformInputManager.GetButton("Trigger")) {
				playerAbilities.SendAb ("Speed", 2);
			}

			if (CrossPlatformInputManager.GetButton("Strength") && CrossPlatformInputManager.GetButton("Trigger")) {
				playerAbilities.SendAb ("Strength", 2);
			}

			if (CrossPlatformInputManager.GetButtonDown("Strength") && PlayerPrefs.GetInt("StrengthP1") == 1) {
				this.gameObject.GetComponentInChildren<BoxCollider>().enabled = true;
			}

			if (CrossPlatformInputManager.GetButtonUp("Strength")) {
				this.gameObject.GetComponentInChildren<BoxCollider>().enabled = false;
			}
				
			if (CrossPlatformInputManager.GetButtonDown("Hacker") && PlayerPrefs.GetInt("HackerP1") == 1) {
				this.gameObject.GetComponentInChildren<SphereCollider> ().enabled = true;
			}

			if (CrossPlatformInputManager.GetButtonUp("Hacker")) {
				this.gameObject.GetComponentInChildren<SphereCollider> ().enabled = false;
			}
		}

		if (this.gameObject.name == "Player2") {
			if (CrossPlatformInputManager.GetButton("HackerJoy") && CrossPlatformInputManager.GetButton("TriggerJoy")) {
				playerAbilities.SendAb ("Hacker", 1);
			}

			if (CrossPlatformInputManager.GetButton("JumpJoy") && CrossPlatformInputManager.GetButton("TriggerJoy")) {
				playerAbilities.SendAb ("Jump", 1);
			}

			if (CrossPlatformInputManager.GetButton("SpeedJoy") && CrossPlatformInputManager.GetButton("TriggerJoy")) {
				playerAbilities.SendAb ("Speed", 1);
			}

			if (CrossPlatformInputManager.GetButton("StrengthJoy") && CrossPlatformInputManager.GetButton("TriggerJoy")) {
				playerAbilities.SendAb ("Strength", 1);
			}

			if (CrossPlatformInputManager.GetButtonDown("StrengthJoy") && PlayerPrefs.GetInt("StrengthP2") == 1) {
				this.gameObject.GetComponentInChildren<BoxCollider>().enabled = true;
			}

			if (CrossPlatformInputManager.GetButtonUp("StrengthJoy")) {
				this.gameObject.GetComponentInChildren<BoxCollider>().enabled = false;
			}

			if (CrossPlatformInputManager.GetButtonDown("HackerJoy") && PlayerPrefs.GetInt("HackerP2") == 1) {
				this.gameObject.GetComponentInChildren<SphereCollider>().enabled = true;
			}

			if (CrossPlatformInputManager.GetButtonUp("HackerJoy")) {
				this.gameObject.GetComponentInChildren<SphereCollider>().enabled = false;
			}
		}
	}
}
