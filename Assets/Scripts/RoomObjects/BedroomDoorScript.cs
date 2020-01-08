using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedroomDoorScript : MonoBehaviour {

	private Animator _myanim;

	// Use this for initialization
	void Start () {

		_myanim = GetComponent<Animator> ();
		IdleBedRoomDoor ();
	}

	// Update is called once per frame
	void Update () {

	}

	public void IdleBedRoomDoor(){
		_myanim.SetBool ("BedRoomDoorIdle", true);
	}

	public void OpenBedRoomDoor(){
		_myanim.SetBool ("BedRoomDoorIdle", false);
	}
}
