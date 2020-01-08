using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DresserTopScript : MonoBehaviour {

	public Animator _myanim;

	// Use this for initialization
	void Start () {

		_myanim = GetComponent<Animator> ();

	}

	// Update is called once per frame
	void Update () {

//		if (Input.GetKeyDown (KeyCode.O)) {
//			OpenCloseTop ();
//		}
//
//		if (Input.GetKeyDown (KeyCode.I)) {
//			IdleTop ();
//		}


	}

	public void OpenCloseTop(){
		_myanim.SetBool ("OpenCloseTop", true);
		_myanim.SetBool ("IdleTop", false);
	}

	public void IdleTop(){
		_myanim.SetBool ("IdleTop", true);
		_myanim.SetBool ("OpenCloseTop", false);
	}
}
