using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightingLightScript : MonoBehaviour {

	public GameObject Light1;
	public GameObject Light2;

	// Use this for initialization
	void Start () {
		LightingOff ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LightingOn(){
		Light1.SetActive (true);
		Light2.SetActive (true);
	}

	public void LightingOff(){
		Light1.SetActive (false);
		Light2.SetActive (false);
	}
}
