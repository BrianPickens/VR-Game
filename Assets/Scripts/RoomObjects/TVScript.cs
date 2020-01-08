using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVScript : MonoBehaviour {

	public GameObject EmergencyBroadCast;
	public GameObject TVLight;

	// Use this for initialization
	void Start () {
		TurnOffTV ();
	}
	
	// Update is called once per frame
	void Update () {

//		if (Input.GetKeyDown (KeyCode.O)) {
//			TurnOnEmergencyNormal ();
//		}
//
//		if (Input.GetKeyDown (KeyCode.F)) {
//			TurnOffTV ();
//		}

	}

	public void TurnOnEmergencyNormal(){
		EmergencyBroadCast.SetActive (true);
		TVLight.SetActive (true);
	}

	public void TurnOnEmergencyEnd(){
		EmergencyBroadCast.SetActive (true);
		TVLight.SetActive (true);
	}

	public void TurnOffTV(){
		EmergencyBroadCast.SetActive (false);
		TVLight.SetActive (false);
	}
}
