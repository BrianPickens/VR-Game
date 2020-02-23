using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CeilingFanScript : MonoBehaviour {

	private Animator _myanim;

	// Use this for initialization
	void Start () {

		_myanim = GetComponent<Animator> ();
		FanOn ();
		NormalFanSpeed ();
	}
	
	// Update is called once per frame
	void Update () {

//		if (Input.GetKeyDown (KeyCode.N)) {
//			NormalFanSpeed ();
//		}
//
//		if (Input.GetKeyDown (KeyCode.F)) {
//			FastFanSpeed ();
//		}
//
//		if (Input.GetKeyDown (KeyCode.S)) {
//			StartCoroutine (IdleFan ());
//		}
//
//		if (Input.GetKeyDown (KeyCode.O)) {
//			FanOn ();
//		}

	}

	public void FanOn(){
		_myanim.SetBool ("CeilingFanOn", true);
	}

	public void FanOff(){
		_myanim.SetBool ("CeilingFanOn", false);
	}

	public void NormalFanSpeed (){
		_myanim.speed = 0.5f;
	}

	public void FastFanSpeed (){
		_myanim.speed = 1f;
	}

	public void IdleFan(){
		StartCoroutine (IdleFanCo ());
	}

	public IEnumerator IdleFanCo(){
		while (_myanim.speed > 0.02) {
			_myanim.speed -= 0.01f;
			yield return new WaitForSeconds (0.03f);
		}
		_myanim.speed = 0f;
		FanOff ();
	}

}
