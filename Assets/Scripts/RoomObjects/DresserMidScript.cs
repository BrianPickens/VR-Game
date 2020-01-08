using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DresserMidScript : MonoBehaviour {

	public Animator _myanim;

	// Use this for initialization
	void Start () {

		_myanim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {

//		if (Input.GetKeyDown (KeyCode.O)) {
//			SlowOpenMid ();
//		}
//		
//		if (Input.GetKeyDown (KeyCode.A)) {
//			SlamMid ();
//		}
//		
//		if (Input.GetKeyDown (KeyCode.C)) {
//			OpenCloseMid ();
//		}
//		
//		if (Input.GetKeyDown (KeyCode.I)) {
//			IdleMid ();
//		}
	}

	public void SlowOpenMid(){
		_myanim.SetBool ("SlowOpenMid", true);
		_myanim.SetBool ("IdleMid", false);
	}

	public void SlamMid(){
		_myanim.SetBool ("SlamMid", true);
		_myanim.SetBool ("SlowOpenMid", false);
	}

	public void OpenCloseMid(){
		_myanim.SetBool ("IdleMid", false);
		_myanim.SetBool ("OpenCloseMid", true);
	}

	public void IdleMid(){
		_myanim.SetBool ("IdleMid", true);
		_myanim.SetBool ("OpenCloseMid", false);
		_myanim.SetBool ("SlamMid", false);
	}
}
