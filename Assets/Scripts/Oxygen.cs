using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oxygen : MonoBehaviour {

	public float GlobalOxygen;
	public float[] RoomOxygen;

	public float Timer;

	public float GlobalOxygenStep;
	public float[] RoomOxygenStep;

	public int CurrentRoom;

	void Start () {
		GlobalOxygen = 120f;
		RoomOxygen = new float[] {20f, 30f};

		GlobalOxygenStep = 2f;
		RoomOxygenStep = new float[] {1f, 2f};

		CurrentRoom = 0;

		Timer = 0f;
	}

	void Update () {
		Timer *= Time.deltaTime;

		if (Timer % GlobalOxygenStep == 0) {
			ReduceGlobalOxygen (1f);
		}

		if (Timer%RoomOxygenStep[CurrentRoom] == 0) {
			ReduceRoomOxygen(CurrentRoom, 1f);
		}
	}

	public void ReduceGlobalOxygen(float x) {
		GlobalOxygen -= x;
	}

	public void IncrementGlobalOxygen(float x){
		GlobalOxygen += x;
	}

	public void ReduceRoomOxygen(int nRoom, float x) {
		RoomOxygen [nRoom] -= x;
	}

	public void IncrementRoomOxygen(int nRoom, float x) {
		RoomOxygen [nRoom] += x;
	}
}
