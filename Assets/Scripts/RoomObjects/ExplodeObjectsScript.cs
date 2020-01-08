using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeObjectsScript : MonoBehaviour {

	private Rigidbody _myRigidbody;
	public float xforce;
	public float yforce;
	public float zforce;

	public float xtorque;
	public float ytorque;
	public float ztorque;

	// Use this for initialization
	void Start () {
		_myRigidbody = GetComponent<Rigidbody> ();
		_myRigidbody.isKinematic = true;
	}
	
	// Update is called once per frame
	void Update () {

//		if (Input.GetKeyDown (KeyCode.E)) {
//			ExplodeObjects ();
//		}

	}

	public void ExplodeObjects(){
		StartCoroutine (ExplodObjectsCo ());

	}

	IEnumerator ExplodObjectsCo(){
		_myRigidbody.isKinematic = false;
		_myRigidbody.AddForce (new Vector3 (xforce, yforce, zforce));
		_myRigidbody.AddTorque (new Vector3 (xtorque, ytorque, ztorque));
		yield return new WaitForSeconds (5f);
		_myRigidbody.isKinematic = true;
	}
}
