using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightStandTopScript : MonoBehaviour {

	public Animator _myanim;

	// Use this for initialization
	void Start () {

		_myanim = GetComponent<Animator> ();

	}

	// Update is called once per frame
	void Update () {

//		if (Input.GetKeyDown (KeyCode.O)) {
//			OpenCloseNStop ();
//		}
//
//		if (Input.GetKeyDown (KeyCode.I)) {
//			IdleNStop ();
//		}


	}

	public void OpenCloseNStop(){
		_myanim.SetBool ("OpenCloseNStop", true);
		_myanim.SetBool ("IdleNStop", false);
	}

	public void IdleNStop(){
		_myanim.SetBool ("IdleNStop", true);
		_myanim.SetBool ("OpenCloseNStop", false);
		_myanim.SetBool ("OpenNSTop", false);
		_myanim.SetBool ("CloseNSTop", false);
	}

	public void OpenNSTop (){
		_myanim.SetBool ("IdleNStop", false);
		_myanim.SetBool ("OpenNSTop", true);
	}

	public void CloseNSTop (){
		_myanim.SetBool ("OpenNSTop", false);
		_myanim.SetBool ("CloseNSTop", true);
	}
}
