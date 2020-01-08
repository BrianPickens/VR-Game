using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PictureFrame2Script : MonoBehaviour {

	public Animator _myanim;

	// Use this for initialization
	void Start () {

		_myanim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PictureFrame2Fall(){
		_myanim.SetBool ("PictureFrame2Fall", true);
	}

}
