using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	/// <summary>
	/// Riferimento al personaggio.
	/// </summary>
	private GameObject player;

	// Use this for initialization
	void Start () {
		// Se è la telecamera 1.
		if (this.name == "Main Camera")
			// Si attacca al player 1.
			player = GameObject.Find ("Player1");
		// Se è la telecamera 2.
		else if (this.name == "Main Camera 2")
			// Si attacca al player 2.
			player = GameObject.Find ("Player2");
	}
	
	// Update is called once per frame
	void Update () {
		// La mia posizione diventa quella del player.
		transform.position = player.transform.position;
		// La mia rotazione diventa quella del player.
		transform.rotation = player.transform.rotation;
	}
}
