using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingWhisperScript : MonoBehaviour {

	private bool gameStart;
	private bool increaseVolume;

	// Use this for initialization
	void Start () {
		StartCoroutine (WhisperVolume ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void TurnUpWhisperVolume(){
		increaseVolume = true;
	}

	public void TurnDownWhisperVolue(){
		increaseVolume = false;
	}

	IEnumerator WhisperVolume(){
		while (!gameStart) {
			if (increaseVolume) {
				if (GetComponent<AudioSource> ().volume < 0.2f) {
					GetComponent<AudioSource> ().volume += 0.01f;
				}
			} else {
				GetComponent<AudioSource> ().volume -= 0.01f;
			}
			yield return new WaitForSeconds (0.01f);
		}
		gameStart = true;
	}
}
