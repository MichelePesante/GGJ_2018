using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float Speed = 0.1f;

	void Start () {
		
	}

	void Update () {
		if (Input.GetKey(KeyCode.W)) {
			transform.position += new Vector3 (0, 0, Speed);
		} 
		else if (Input.GetKey(KeyCode.S)) {
			transform.position += new Vector3 (0, 0, -Speed);
		}

		if (Input.GetKey(KeyCode.A)) {
			transform.position += new Vector3 (-Speed, 0, 0);
		} 
		else if (Input.GetKey(KeyCode.D)) {
			transform.position += new Vector3 (Speed, 0, 0);
		} 
	}
}
