using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairScript : MonoBehaviour {

	public Animator _myanim;
	public GameObject ChairHolder;

	// Use this for initialization
	void Start () {

		_myanim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {

//		if (Input.GetKeyDown (KeyCode.R)) {
//			ChairCanRock ();
//		}
//
//		if (Input.GetKeyDown (KeyCode.F)) {
//			ChairRockForward ();
//		}
//
//		if (Input.GetKeyDown (KeyCode.B)) {
//			ChairRockBackward ();
//		}
//
//		if (Input.GetKeyDown (KeyCode.I)) {
//			ChairIdle ();
//		}
//
//		if (Input.GetKeyDown (KeyCode.S)) {
//			ChairSpin ();
//		}
//
//		if (Input.GetKeyDown (KeyCode.C)) {
//			ChairSpinIdle ();
//		}

	}

	public void ChairCanRock(){
		_myanim.SetBool ("ChairRocking", true);
	}

	public void ChairRockForward(){
		_myanim.SetBool ("ChairRockBackward", false);
		_myanim.SetBool ("ChairRockForward", true);
	}

	public void ChairRockBackward(){
		_myanim.SetBool ("ChairRockForward", false);
		_myanim.SetBool ("ChairRockBackward", true);
	}

	public void ChairIdle(){
		_myanim.SetBool ("ChairRockBackward", false);
		_myanim.SetBool ("ChairRockForward", false);
		_myanim.SetBool ("ChairRocking", false);
	}

	public void ChairSpinSet(){
		_myanim.SetBool ("ChairSpinSet", true);
	}

	public void ChairSpin(){
		_myanim.SetBool ("ChairSpin", true);
	}

	public void ChairSpinIdle(){
		_myanim.SetBool ("ChairSpin", false);
	}

	public void ChairSpeedUp(){
		_myanim.speed += 0.2f;
	}

	public void ChairSpeedNormal(){
		_myanim.speed = 1f;
	}

	public void ChairTurnOff (){
		ChairHolder.SetActive (false);
	}

	public void ChairTurnOn (){
		ChairHolder.SetActive (true);
	}
}
