using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float movementSpeed = 0.1f;

	public float rotationSpeed = 0.1f;

	void Start () {
		
	}

	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			Movement (Vector3.forward, movementSpeed);
		}
		if (Input.GetKey(KeyCode.S)) {
			Movement (Vector3.back, movementSpeed);
		}

		if (Input.GetKey(KeyCode.A)) {
			Movement (Vector3.left, movementSpeed);
		} 
		if (Input.GetKey(KeyCode.D)) {
			Movement (Vector3.right, movementSpeed);
		} 
	}

	public void Movement (Vector3 _direction, float _speed) {
		transform.position = transform.position + _direction * _speed;
	}

	public void LookAround () {
		
	}
}
