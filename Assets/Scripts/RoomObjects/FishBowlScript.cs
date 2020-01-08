using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishBowlScript : MonoBehaviour {

	private Animator _myanim;

	// Use this for initialization
	void Start () {

		_myanim = GetComponent<Animator> ();
		IdleFishBowl ();
	}

	// Update is called once per frame
	void Update () {

	}

	public void IdleFishBowl(){
		_myanim.SetBool ("FishBowlIdle", true);
	}

	public void ShakeFishBowl(){
		_myanim.SetBool ("FishBowlIdle", false);
	}
}