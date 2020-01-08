using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TvRemoteScript : MonoBehaviour {

	public Animator _myanim;
	public Rigidbody _myRigidbody;

	// Use this for initialization
	void Start () {

		_myanim = GetComponent<Animator> ();
		_myRigidbody = GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void TvRemoteIdle(){
		_myanim.SetBool ("TvRemoteTwitch", false);
		_myanim.SetBool ("TvRemoteIdle", true);
	}

	public void TvRemoteTwitch(){
		StartCoroutine (TvRemoteTwitchCo ());
	}

	public void TvRemoteSlide(){
		StartCoroutine (TvRemoteSlideCo ());
	}

	public IEnumerator TvRemoteTwitchCo(){
		_myanim.SetBool ("TvRemoteIdle", false);
		_myanim.SetBool ("TvRemoteTwitch", true);
		yield return new WaitForSecondsRealtime (0.16f);
		_myanim.SetBool ("TvRemoteTwitch", false);
		_myanim.SetBool ("TvRemoteIdle", true);
	}

	public IEnumerator TvRemoteSlideCo(){
		_myanim.SetBool ("TvRemoteIdle", false);
		_myanim.SetBool ("TvRemoteSlide", true);
		yield return new WaitForSeconds (4f);
		_myanim.enabled = false;
		_myRigidbody.isKinematic = false;
	}

}
