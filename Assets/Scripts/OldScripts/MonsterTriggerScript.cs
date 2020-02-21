using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterTriggerScript : LookTarget {

	public GameObject BedsideMonster;
	public CameraBlackOut BlackOut;

	protected override void StartLookResponse()
	{
		base.StartLookResponse();
		LookingAtMonster();
		gameObject.SetActive(false);
	}

	public void LookingAtMonster(){
		BedsideMonster.GetComponent<BedsideMonsterScript> ().PopMonster ();
		StartCoroutine(DelayBeforeBlackoutCo());
	}

	private IEnumerator DelayBeforeBlackoutCo()
	{
		yield return new WaitForSeconds(1f);
		BlackOut.FadeInBlocker(StartEndRoutine);
	}

	public void StartEndRoutine()
	{
		StartCoroutine(EndGameCo());
	}

	IEnumerator EndGameCo()
	{
		yield return new WaitForSeconds(3f);
		SceneLoader.Instance.LoadScene("EndScreen");
	}


}
