using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskBotScript : MonoBehaviour {

	public Animator _myanim;

	// Use this for initialization
	void Start () {

		_myanim = GetComponent<Animator> ();

	}

	// Update is called once per frame
	void Update () {

//		if (Input.GetKeyDown (KeyCode.O)) {
//			OpenCloseDeskBot ();
//		}
//
//		if (Input.GetKeyDown (KeyCode.I)) {
//			IdleDeskBot ();
//		}


	}

	public void OpenCloseDeskBot(){
		_myanim.SetBool ("OpenCloseDeskBot", true);
		_myanim.SetBool ("IdleDeskBot", false);
	}

	public void IdleDeskBot(){
		_myanim.SetBool ("IdleDeskBot", true);
		_myanim.SetBool ("OpenCloseDeskBot", false);
	}
}