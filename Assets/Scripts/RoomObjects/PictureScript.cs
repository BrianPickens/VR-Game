using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PictureScript : MonoBehaviour {

	public Animator _myanim;


	// Use this for initialization
	void Start () {

		_myanim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PictureIdle(){
		_myanim.SetBool ("PictureSwing", false);
	}

	public void PictureSwing(){
		_myanim.SetBool ("PictureSwing", true);
	}

}
