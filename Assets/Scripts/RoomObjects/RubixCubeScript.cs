using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubixCubeScript : MonoBehaviour {

	private Animator _myanim;

	// Use this for initialization
	void Start () {

		_myanim = GetComponent<Animator> ();
		IdleRubixCube ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ShakeRubixCube(){
		_myanim.SetBool ("RubixCubeIdle", false);
	}

	public void IdleRubixCube(){
		_myanim.SetBool ("RubixCubeIdle", true);
	}
}
