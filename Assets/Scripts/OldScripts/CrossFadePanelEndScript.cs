using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CrossFadePanelEndScript : MonoBehaviour {

	public GameObject Reticle;
	public GameObject BlackOutPanel;
	public GameObject ReplayButton;

	// Use this for initialization
	void Start () {
		Reticle.GetComponent<MeshRenderer> ().material.color = new Color (255, 255, 255, 1);
		BlackOutPanel.GetComponent<Image> ().CrossFadeAlpha (0, 2, false);
		EndFadeToView ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void EndFadeToBlack(){
		StartCoroutine (RestartGame ());
	}

	public void EndFadeToView(){
		StartCoroutine (EndFadeToViewCo ());
	}

	IEnumerator EndFadeToViewCo(){
		yield return new WaitForSeconds (2f);
		ReplayButton.SetActive (true);
		GetComponent<Image> ().CrossFadeAlpha (0, 2, false);
	}

	IEnumerator RestartGame(){
		BlackOutPanel.GetComponent<Image> ().CrossFadeAlpha (1, 2, false);
		yield return new WaitForSeconds (2.5f);
		SceneManager.LoadScene ("TitleScreen");
	}


}
