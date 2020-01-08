using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookFallScript : MonoBehaviour {

	public Animator _myanim;
	public Rigidbody _myRigidbody;

	// Use this for initialization
	void Start () {

		_myanim = GetComponent<Animator> ();
		_myRigidbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.F)) {
			KnockOffBook ();
		}

	}

	public void KnockOffBook(){
		StartCoroutine (KnockOffBookCo ());
	}

	public IEnumerator KnockOffBookCo(){
		_myanim.SetBool ("KnockOffBook", true);
		yield return new WaitForSeconds (1f);
		_myanim.enabled = false;
		_myRigidbody.isKinematic = false;
	}
}
