using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CrossFadePanelStartSCript : MonoBehaviour {

	public GameObject AdjustLenses;
	public GameObject SeizureWarning;
	public GameObject StartButton;
	public GameObject ScreenBlackOut;

	// Use this for initialization
	void Start () {
		StartCoroutine (FadeToViewStart ());
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            StartCoroutine(FadeToBlackandGame());
        }
	}

	public void FadeToBlack (){
		GetComponent<Image> ().CrossFadeAlpha (1, 2, false);

	}

	public void FadeToBlackaS(){
		StartCoroutine (FadeToBlackandStart ());
	}

	public void FadeToBlackaG(){
		StartCoroutine (FadeToBlackandGame ());
	}

	public void FadeToBlakeaW(){
		StartCoroutine (FadeToBlackandWarning());
	}

	public void FadeToView() {
		GetComponent<Image> ().CrossFadeAlpha (0, 2, false);
	}

	IEnumerator FadeToViewStart(){
		yield return new WaitForSeconds (2f);
		GetComponent<Image> ().CrossFadeAlpha (0, 2, false);
	}

	IEnumerator FadeToBlackandWarning (){
		GetComponent<Image> ().CrossFadeAlpha (1, 2, false);
		yield return new WaitForSeconds (2.3f);
		AdjustLenses.SetActive (false);
		SeizureWarning.SetActive (true);
		FadeToView ();
	}

	IEnumerator FadeToBlackandStart(){
		GetComponent<Image> ().CrossFadeAlpha (1, 2, false);
		yield return new WaitForSeconds (2.3f);
		SeizureWarning.SetActive (false);
		StartButton.SetActive (true);
		FadeToView ();
	}

	IEnumerator FadeToBlackandGame(){
		GetComponent<Image> ().CrossFadeAlpha (1, 2, false);
		yield return new WaitForSeconds (2.5f);
		StartButton.SetActive (false);
		ScreenBlackOut.GetComponent<BlackOutPanelScript> ().BlackOutPanel ();
		yield return new WaitForSeconds (2.5f);

		SceneManager.LoadScene ("Room");
	}
}
