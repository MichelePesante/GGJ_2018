using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilities : MonoBehaviour {

	void Start () {
		PlayerPrefs.SetInt ("JumpP1", 0);
		PlayerPrefs.SetInt ("JumpP2", 1);
		PlayerPrefs.SetInt ("SpeedP1", 1);
		PlayerPrefs.SetInt ("SpeedP2", 0);
		PlayerPrefs.SetInt ("HackerP1", 0);
		PlayerPrefs.SetInt ("HackerP2", 1);
		PlayerPrefs.SetInt ("StrengthP1", 0);
		PlayerPrefs.SetInt ("StrengthP2", 1);
	}

	public void SendAb(string Ability, int Player) {
		if (Ability == "Jump") {
			if (Player == 1) {
				PlayerPrefs.SetInt ("JumpP1", 1);
				PlayerPrefs.SetInt ("JumpP2", 0);
			} else {
				PlayerPrefs.SetInt ("JumpP1", 0);
				PlayerPrefs.SetInt ("JumpP2", 1);
			}
		} 
		else if (Ability == "Speed") {
			if (Player == 1) {
				PlayerPrefs.SetInt ("SpeedP1", 1);
				PlayerPrefs.SetInt ("SpeedP2", 0);
			} else {
				PlayerPrefs.SetInt ("SpeedP1", 0);
				PlayerPrefs.SetInt ("SpeedP2", 1);
			}
		} 
		else if (Ability == "Hacker") {
			if (Player == 1) {
				PlayerPrefs.SetInt ("HackerP1", 1);
				PlayerPrefs.SetInt ("HackerP2", 0);
			} else {
				PlayerPrefs.SetInt ("HackerP1", 0);
				PlayerPrefs.SetInt ("HackerP2", 1);
			}
		} 
		else if (Ability == "Strength") {
			if (Player == 1) {
				PlayerPrefs.SetInt ("StrengthP1", 1);
				PlayerPrefs.SetInt ("StrengthP2", 0);
			} else {
				PlayerPrefs.SetInt ("StrengthP1", 0);
				PlayerPrefs.SetInt ("StrengthP2", 1);
			}
		} 
		else {
		}
	}
}
