using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedMonsterScript : MonoBehaviour {

	private Animator _myanim;

	// Use this for initialization
	void Start () {

		_myanim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
//
//		if (Input.GetKeyDown (KeyCode.H)) {
//			BedMonsterHeadShake ();
//		}

	}

	public void BedMonsterHeadShake(){
		_myanim.SetBool ("BedMonsterShakeHead", true);
	}
}
