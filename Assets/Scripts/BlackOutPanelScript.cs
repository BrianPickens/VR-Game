using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlackOutPanelScript : MonoBehaviour {

	public GameObject Reticle;

	// Use this for initialization
	void Start () {
		//Reticle.GetComponent<MeshRenderer> ().material.color = new Color (255, 255, 255, 1);
		GetComponent<Image> ().CrossFadeAlpha (0, 2, false);
	}
	
	// Update is called once per frame
	void Update () {

	}
		
	public void BlackOutPanel (){

		GetComponent<Image> ().CrossFadeAlpha (1, 2, false);
	}
}
