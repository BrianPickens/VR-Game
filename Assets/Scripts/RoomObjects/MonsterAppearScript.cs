using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAppearScript : MonoBehaviour {

	public GameObject Monster;

	void Start () {
		TurnMonsterOff ();
	}
	

	public void TurnMonsterOn(){
		Monster.SetActive (true);
	}

	public void TurnMonsterOff(){
		Monster.SetActive (false);
	}
}
