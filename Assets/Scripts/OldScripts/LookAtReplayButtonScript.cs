using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LookAtReplayButtonScript : MonoBehaviour {
	public GameObject CrossFadePanel;
	public bool fillOption;
	public GameObject FillButton;

	// Use this for initialization
	void Start () {
		StartCoroutine (FillState ());
	}

	// Update is called once per frame
	void Update () {

	}

	public void ReplayLookedAt(){

		fillOption = true;
	}

	public void ReplayNotLookedAt(){

		fillOption = false;
	}

	IEnumerator FillState(){
		yield return new WaitForSeconds (2.5f);
		while (FillButton.GetComponent<Image> ().fillAmount < 0.99f) {
			if (fillOption) {
				FillButton.GetComponent<Image> ().fillAmount += 0.01f;
			} else {
				FillButton.GetComponent<Image> ().fillAmount -= 0.01f;
			}
			yield return new WaitForSeconds (0.01f);
		}

		CrossFadePanel.GetComponent<CrossFadePanelEndScript> ().EndFadeToBlack ();
	}

}
