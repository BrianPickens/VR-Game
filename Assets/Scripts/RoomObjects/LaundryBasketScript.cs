using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaundryBasketScript : MonoBehaviour {

	private Animator _myanim;

	// Use this for initialization
	void Start () {

		_myanim = GetComponent<Animator> ();
		IdleLaundryBasket ();
	}

	// Update is called once per frame
	void Update () {

	}

	public void IdleLaundryBasket(){
		_myanim.SetBool ("LaundryBasketIdle", true);
	}

	public void ShakeLaundryBasket(){
		_myanim.SetBool ("LaundryBasketIdle", false);
	}
}
