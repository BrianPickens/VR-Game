using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampScript : MonoBehaviour {

	private bool lampFlickering;
	private bool lampShouldOff;
	public float flickerSpeed;
	public float flickerIntensity;
	public float flickerDistance;
	public float NormalRange;
	public GameObject LampShadeOn;
	public GameObject LampShadeOff;
	public GameObject LampShadeDim;

	// Use this for initialization
	void Start () {
		TurnOnLamp ();
		NormalLamp ();
	}
	
	// Update is called once per frame
	void Update () {
//		if (Input.GetKeyDown (KeyCode.F)) {
//			FlickerLamp ();
//		}
//
//		if (Input.GetKeyDown (KeyCode.N)) {
//			NormalLamp ();
//		}
//		if (Input.GetKeyDown (KeyCode.T)) {
//			TurnOnLamp ();
//		}
//		if (Input.GetKeyDown (KeyCode.D)) {
//			LampDim ();
//		}


		if (lampFlickering) {
			float lightrange = Mathf.PingPong(Time.time * flickerSpeed, flickerDistance) + flickerIntensity;
			GetComponent<Light> ().range = lightrange;
			StartCoroutine (LampFlickerCo());
		}

	}

	public void FlickerLamp(){
		TurnOnLamp ();
		lampFlickering = true;
	}

	public void NormalLamp(){
		lampFlickering = false;
		GetComponent<Light> ().range = NormalRange;
	}

	public void LampDim(){
		StartCoroutine (LampDimCo ());
	}

	public void LampDimLow(){
		StartCoroutine (LampDimLowCo ());
	}

	public void TurnOffLamp(){
		lampShouldOff = true;
		GetComponent<Light> ().intensity = 0;
		LampShadeOff.SetActive (true);
		LampShadeOn.SetActive (false);
		LampShadeDim.SetActive (false);
	}

	public void TurnOnLamp() {
		lampShouldOff = false;
		GetComponent<Light> ().intensity = 1;
		LampShadeOn.SetActive (true);
		LampShadeOff.SetActive (false);
		LampShadeDim.SetActive (false);

	}

	public void TurnOnLampHalf(){
		GetComponent<Light> ().intensity = 0.7f;
		LampShadeDim.SetActive (true);
		LampShadeOn.SetActive (false);
		LampShadeOff.SetActive (false);
	}

	public IEnumerator LampDimCo(){
		while(GetComponent<Light> ().intensity > 0){
			GetComponent<Light> ().intensity -= 0.05f;
			yield return new WaitForSeconds (0.1f);
			if (GetComponent<Light> ().intensity < 0.3) {
				NormalLamp ();
				TurnOffLamp ();
			}
		}

	}

	public IEnumerator LampDimLowCo(){
		while(GetComponent<Light> ().intensity > 0.7f){
			GetComponent<Light> ().intensity -= 0.05f;
			yield return new WaitForSeconds (0.1f);
		}
	}

	public IEnumerator LampFlickerCo(){
		while (lampFlickering) {
			LampShadeOn.SetActive (true);
			LampShadeDim.SetActive (false);
			yield return new WaitForSeconds (0.1f);
			LampShadeDim.SetActive (true);
			LampShadeOn.SetActive (false);
			yield return new WaitForSeconds (0.1f);
		}
		LampShadeDim.SetActive (false);
		if (lampShouldOff) {
			LampShadeOff.SetActive (true);
			LampShadeOn.SetActive (false);
		} else {
			LampShadeDim.SetActive (false);
			LampShadeOn.SetActive (true);
		}

	}
}
