using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterGlassScript : MonoBehaviour {

	private Animator _myanim;

	// Use this for initialization
	void Start () {

		_myanim = GetComponent<Animator> ();
		IdleWaterGlass ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void IdleWaterGlass(){
		_myanim.SetBool ("WaterGlassIdle", true);
	}

	public void ShakeWaterGlass(){
		_myanim.SetBool ("WaterGlassIdle", false);
	}
}
