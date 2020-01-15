using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LookAtAdjustButtonScript : MonoBehaviour {

	public GameObject CrossFadePanel;
	public bool fillOption;
	public GameObject FillButton;
	public GameObject VolumeControl;

	// Use this for initialization
	void Start () {
		StartCoroutine (FillState ());
	}

	// Update is called once per frame
	void Update () {

	}

	public void SeizureLookedAt(){
		fillOption = true;

	}

	public void SeizureNotLookedAt(){

		fillOption = false;
	
	}

	IEnumerator FillState(){
		yield return new WaitForSeconds (2.5f);
		while (FillButton.GetComponent<Image> ().fillAmount < 0.99f) {
			if (fillOption) {
				FillButton.GetComponent<Image> ().fillAmount += 0.01f;
				VolumeControl.GetComponent<StartingWhisperScript> ().TurnUpWhisperVolume ();
			} else {
				FillButton.GetComponent<Image> ().fillAmount -= 0.01f;
				VolumeControl.GetComponent<StartingWhisperScript> ().TurnDownWhisperVolue ();
			}
			yield return new WaitForSeconds (0.01f);
		}

        SceneManager.LoadScene("ClassRoomSizing");


        VolumeControl.GetComponent<StartingWhisperScript> ().TurnDownWhisperVolue ();
		CrossFadePanel.GetComponent<CrossFadePanelStartSCript> ().FadeToBlakeaW ();
	}

}
