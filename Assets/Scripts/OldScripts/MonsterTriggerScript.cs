using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterTriggerScript : MonoBehaviour {

	public GameObject BedsideMonster;
	public GameObject GameEnder;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LookingAtMonster(){
		BedsideMonster.GetComponent<BedsideMonsterScript> ().PopMonster ();
		GameEnder.GetComponent<FadeIntroScript> ().BlackOutEnding ();
	}

}
