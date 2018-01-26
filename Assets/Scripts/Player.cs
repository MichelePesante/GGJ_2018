using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float Speed = 0.1f;

	void Start () {
		
	}

	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			Movement (Vector3.forward, Speed);
		}
		if (Input.GetKey(KeyCode.S)) {
			Movement (Vector3.back, Speed);
		}

		if (Input.GetKey(KeyCode.A)) {
			Movement (Vector3.left, Speed);
		} 
		if (Input.GetKey(KeyCode.D)) {
			Movement (Vector3.right, Speed);
		} 
	}

	public void Movement (Vector3 _direction, float _speed) {
		transform.position = transform.position + _direction * _speed;
	}
}
