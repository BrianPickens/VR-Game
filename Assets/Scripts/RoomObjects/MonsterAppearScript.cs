using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAppearScript : MonoBehaviour {

	public GameObject Monster;

	// Use this for initialization
	void Start () {
		TurnMonsterOff ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void TurnMonsterOn(){
		Monster.SetActive (true);
	}

	public void TurnMonsterOff(){
		Monster.SetActive (false);
	}
}
