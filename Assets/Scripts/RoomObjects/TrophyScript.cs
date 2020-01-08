using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TrophyScript : MonoBehaviour {

	public Animator _myanim;
	public Rigidbody _myRigidbody;

	// Use this for initialization
	void Start () {

		_myanim = GetComponent<Animator> ();
		_myRigidbody = GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {

//		if (Input.GetKeyDown (KeyCode.O)) {
//			TrophyShakeOnce ();
//		}
//
//		if (Input.GetKeyDown (KeyCode.S)) {
//			TrophyShakeConstant ();
//		}
//
//		if (Input.GetKeyDown (KeyCode.I)) {
//			TrophyIdle ();
//		}
//
//		if (Input.GetKeyDown (KeyCode.F)) {
//			TrophyFall ();
//		}

	}

	public void TrophyShakeOnce(){
		StartCoroutine (TrophyShakeOnceCo ());
	}

	public void TrophyShakeConstant(){
		_myanim.SetBool ("TrophyIdle", false);
		_myanim.SetBool ("TrophyShake", true);
	}

	public void TrophyIdle(){
		_myanim.SetBool ("TrophyShake", false);
		_myanim.SetBool ("TrophyIdle", true);
	}

	public void TrophyFall(){
		StartCoroutine (TrophyFallCo ());
	}

	public IEnumerator TrophyShakeOnceCo(){
		_myanim.SetBool ("TrophyIdle", false);
		_myanim.SetBool ("TrophyShake", true);
		yield return new WaitForSeconds (0.4f);
		_myanim.SetBool ("TrophyShake", false);
		_myanim.SetBool ("TrophyIdle", true);
	}

	public IEnumerator TrophyFallCo(){
		_myanim.SetBool ("TrophyFall", true);
		yield return new WaitForSeconds (0.95f);
		_myanim.enabled = false;
		_myRigidbody.isKinematic = false;
	}

}
