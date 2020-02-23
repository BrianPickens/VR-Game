using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterTriggerScript : LookTarget {

	public GameObject BedsideMonster;
	public CameraBlackOut BlackOut;
	private bool triggered = false;

	private void Start()
	{
		isPressable = true;
	}

	protected override void StartLookResponse()
	{
		base.StartLookResponse();
		if (!triggered)
		{
			triggered = true;
			LookingAtMonster();
		}
	}

	public void LookingAtMonster(){
		BedsideMonster.GetComponent<BedsideMonsterScript> ().PopMonster ();
		StartCoroutine(DelayBeforeBlackoutCo());
	}

	private IEnumerator DelayBeforeBlackoutCo()
	{
		yield return new WaitForSeconds(0.75f);
		BlackOut.FadeInBlocker(StartEndRoutine, 10f);
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
