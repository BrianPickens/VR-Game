using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterTriggerScript : LookTarget {

	public GameObject BedsideMonster;
	public GameObject GameEnder;

	protected override void StartLookResponse()
	{
		base.StartLookResponse();
		LookingAtMonster();
		gameObject.SetActive(false);
	}

	public void LookingAtMonster(){
		BedsideMonster.GetComponent<BedsideMonsterScript> ().PopMonster ();
		GameEnder.GetComponent<FadeIntroScript> ().BlackOutEnding ();
	}

}
