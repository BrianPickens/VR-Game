using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DresserBotScript : MonoBehaviour {

	public Animator _myanim;

	// Use this for initialization
	void Start () {

		_myanim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {

//		if (Input.GetKeyDown (KeyCode.O)) {
//			OpenCloseBot ();
//		}
//
//		if (Input.GetKeyDown (KeyCode.I)) {
//			IdleBot ();
//		}


	}

	public void OpenCloseBot(){
		_myanim.SetBool ("OpenCloseBot", true);
		_myanim.SetBool ("IdleBot", false);
	}

	public void IdleBot(){
		_myanim.SetBool ("IdleBot", true);
		_myanim.SetBool ("OpenCloseBot", false);
	}
}
