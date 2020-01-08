using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedsideMonsterScript : MonoBehaviour {

	private Animator _myanim;
	private bool canTriggerMonster;
	public AudioClip MonsterScream;
	private bool popped;


	// Use this for initialization
	void Start () {

		_myanim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {

//		if (Input.GetKeyDown (KeyCode.M)) {
//			AllowMonsterPop ();
//			PopMonster ();
//		}

	}

	public void AllowMonsterPop(){
		canTriggerMonster = true;
	}

	public void PopMonster(){
		if (canTriggerMonster && !popped) {
			_myanim.SetBool ("MonsterPop", true);
			popped = true;
			GetComponent<AudioSource> ().PlayOneShot (MonsterScream);
		}
	}
}
