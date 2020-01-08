using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosetDoorScript : MonoBehaviour {

	private Animator _myanim;

	// Use this for initialization
	void Start () {

		_myanim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {

//		if (Input.GetKeyDown (KeyCode.O)) {
//			SlowOpenCloset ();
//		}
//
//		if (Input.GetKeyDown (KeyCode.A)) {
//			OpenCloseCloset ();
//		}
//
//		if (Input.GetKeyDown (KeyCode.C)) {
//			CloseCloset ();
//		}
//
//		if (Input.GetKeyDown (KeyCode.I)) {
//			IdleCloset ();
//		}


	}

	public void SlowOpenCloset(){
		_myanim.SetBool ("SlowOpen", true);
		_myanim.SetBool ("Idle", false);
	}

	public void OpenCloseCloset(){
		_myanim.SetBool ("OpenClose", true);
		_myanim.SetBool ("SlowOpen", false);
	}

	public void CloseCloset(){
		_myanim.SetBool ("Close", true);
		_myanim.SetBool ("OpenClose", false);
	}

	public void IdleCloset(){
		_myanim.SetBool ("SlowOpen", false);
		_myanim.SetBool ("Idle", true);
		_myanim.SetBool ("Close", false);
	}
}
