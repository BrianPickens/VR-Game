using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockScript : MonoBehaviour {

	public Animator _myanim;

	// Use this for initialization
	void Start () {

		_myanim = GetComponent<Animator> ();
		ClockSwingPendulum ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ClockSwingPendulum(){
		_myanim.SetBool ("ClockSwingPendulum", true);
	}

	public void ClockIdlePendulum(){
		_myanim.SetBool ("ClockSwingPendulum", false);
	}
}
