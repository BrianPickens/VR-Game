using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TissueBoxScript : MonoBehaviour {

	private Animator _myanim;

	// Use this for initialization
	void Start () {

		_myanim = GetComponent<Animator> ();
		IdleTissueBox ();
	}

	// Update is called once per frame
	void Update () {

	}

	public void IdleTissueBox(){
		_myanim.SetBool ("TissueBoxIdle", true);
	}

	public void ShakeTissueBox(){
		_myanim.SetBool ("TissueBoxIdle", false);
	}
}