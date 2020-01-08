using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockHandsSCript : MonoBehaviour {

	private Animator _myanim;

	// Use this for initialization
	void Start () {

		_myanim = GetComponent<Animator> ();
		IdleClockHands ();
	}

	// Update is called once per frame
	void Update () {

	}

	public void IdleClockHands(){
		_myanim.SetBool ("ClockHandsIdle", true);
	}

	public void SpinClockHands(){
		_myanim.SetBool ("ClockHandsIdle", false);
	}
}
