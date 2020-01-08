using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosetLightScript : MonoBehaviour {

	private bool lightFlickering;
	public float flickerSpeed;
	public float flickerIntensity;
	public float flickerDistance;
	public float NormalRange;

	// Use this for initialization
	void Start () {
		TurnOffClosetLight ();
	}

	// Update is called once per frame
	void Update () {
//		if (Input.GetKeyDown (KeyCode.F)) {
//			FlickerClosetLight ();
//		}
//
//		if (Input.GetKeyDown (KeyCode.N)) {
//			NormalClosetLight ();
//		}
//
//		if (Input.GetKeyDown (KeyCode.O)) {
//			TurnOnClosetLight ();
//		}

		if (lightFlickering) {
			float lightrange = Mathf.PingPong(Time.time * flickerSpeed, flickerDistance) + flickerIntensity;
			GetComponent<Light> ().range = lightrange;
		}

	}

	public void FlickerClosetLight(){
		TurnOnClosetLight ();
		lightFlickering = true;
	}

	public void NormalClosetLight(){
		lightFlickering = false;
		GetComponent<Light> ().range = NormalRange;
	}

	public void TurnOffClosetLight(){

		GetComponent<Light> ().intensity = 0;

	}

	public void TurnOnClosetLight() {

		GetComponent<Light> ().intensity = 1;

	}

	public void SlowTurnOn(){
		StartCoroutine (SlowTurnOnCo ());
	}

	public IEnumerator SlowTurnOnCo(){
		while (GetComponent<Light> ().intensity < 1) {
			GetComponent<Light> ().intensity += 0.01f;
			yield return new WaitForSeconds (0.02f);
		}
		GetComponent<Light> ().intensity = 1f;
	}
}
