using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskTopScript : MonoBehaviour {

	public Animator _myanim;

	// Use this for initialization
	void Start () {

		_myanim = GetComponent<Animator> ();

	}

	// Update is called once per frame
	void Update () {

//		if (Input.GetKeyDown (KeyCode.O)) {
//			OpenCloseDeskTop ();
//		}
//		
//		if (Input.GetKeyDown (KeyCode.I)) {
//			IdleDeskTop ();
//		}


	}

	public void OpenCloseDeskTop(){
		_myanim.SetBool ("OpenCloseDeskTop", true);
		_myanim.SetBool ("IdleDeskTop", false);
	}

	public void IdleDeskTop(){
		_myanim.SetBool ("IdleDeskTop", true);
		_myanim.SetBool ("OpenCloseDeskTop", false);
	}
}