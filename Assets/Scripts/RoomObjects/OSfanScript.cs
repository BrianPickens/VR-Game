using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OSfanScript : MonoBehaviour {
	private Animator _myanim;

	// Use this for initialization
	void Start () {

		_myanim = GetComponent<Animator> ();
		OSfanOn ();
	}

	// Update is called once per frame
	void Update () {

//		if (Input.GetKeyDown (KeyCode.O)) {
//			OSfanOn ();
//		}
//		
//		if (Input.GetKeyDown (KeyCode.I)) {
//			OSfanOff ();
//		}
//
//		if (Input.GetKeyDown (KeyCode.S)) {
//			StartCoroutine (IdleOSfan ());
//		}


	}

	public void OSfanOn(){
		_myanim.speed = 0.3f;
		_myanim.SetBool ("OSfanOff", false);
		_myanim.SetBool ("OSfanOn", true);

	}

	public void OSfanOnFast(){
		_myanim.speed = 1f;
		_myanim.SetBool ("OSfanOff", false);
		_myanim.SetBool ("OSfanOn", true);
	}

	public void OSfanOff(){
		_myanim.SetBool ("OSfanOn", false);
		_myanim.SetBool ("OSfanOff", true);
	}

	public void IdleOSfan(){
		StartCoroutine(IdleOSfanCo());
	}

	public IEnumerator IdleOSfanCo(){
		while (_myanim.speed > 0) {
			_myanim.speed -= 0.01f;
			yield return new WaitForSeconds (0.03f);
		}
		_myanim.speed = 0f;
		OSfanOff ();
	}

}