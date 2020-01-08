using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteBoardScript : MonoBehaviour {

	private Animator _myanim;

	// Use this for initialization
	void Start () {

		_myanim = GetComponent<Animator> ();
		IdleWhiteBoard ();
	}

	// Update is called once per frame
	void Update () {

	}

	public void IdleWhiteBoard(){
		_myanim.SetBool ("WhiteBoardIdle", true);
	}

	public void ShakeWhiteBoard(){
		_myanim.SetBool ("WhiteBoardIdle", false);
	}
}