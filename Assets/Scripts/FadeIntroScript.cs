using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeIntroScript : MonoBehaviour {


	// Use this for initialization
	void Start () {
		GetComponent<Image> ().CrossFadeAlpha (0, 2, false);
	}
	
	// Update is called once per frame
	void Update () {


	}

	public void BlackOutEnding(){
		StartCoroutine (EndGame ());
	}

	IEnumerator EndGame(){
		yield return new WaitForSeconds (1f);
		GetComponent<Image> ().canvasRenderer.SetAlpha (1);
		yield return new WaitForSeconds (3f);
		SceneManager.LoadScene ("EndScreen");
	}

}
