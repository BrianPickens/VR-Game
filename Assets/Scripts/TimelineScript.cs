using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimelineScript : MonoBehaviour {

	//delete this after release
	public bool runGame;
	//end delete after release

	//private bool gameOn;

	public GameObject SoundEffects;
	public GameObject Lamp;
	public GameObject LightningLight;
	public GameObject ClosetLight;
	public GameObject ClosetDoor;
	public GameObject CeilingFan;
	public GameObject OsFan;
	public GameObject DresserTop;
	public GameObject DresserBot;
	public GameObject DresserMid;
	public GameObject NightStandTop;
	public GameObject DeskTop;
	public GameObject DeskBot;
	public GameObject TV;
	public GameObject Trophy;
	public GameObject Trophy1;
	public GameObject Trophy6;
	public GameObject Trophy7;
	public GameObject Trophy8;
	public GameObject Book6;
	public GameObject Book7;
	public GameObject Chair;
	public GameObject Picture1;
	public GameObject Picture2;
	public GameObject PictureFrame1;
	public GameObject PictureFrame2;
	public GameObject Remote;
	public GameObject Clock;
	public GameObject RubixCube;
	public GameObject WaterGlass;
	public GameObject LaundryBasket;
	public GameObject ClockHands;
	public GameObject TissueBox;
	public GameObject WhiteBoard;
	public GameObject FishBowl;
	public GameObject BedroomDoor;

	public GameObject[] PileOfThings;
	private int pileNumber;


	public GameObject ChairMonster;
	public GameObject ClosetMonster;
	public GameObject DeskMonster;
	public GameObject BedFootMonster;
	public GameObject BedFootCrawlMonster;
	public GameObject BedsideMonster;
	public GameObject BedMonster;
	public GameObject BedsideMonsterTrigger;

	private float timeLapsed;

	// Use this for initialization
	void Start () {
		//delete the if after release
		if (runGame) {
			BeginGame ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
//		if (gameOn) {
//			timeLapsed += Time.deltaTime;
//			Debug.Log (Mathf.RoundToInt (timeLapsed));
//		}

	}

	public void BeginGame(){
		//Debug.Log ("GAME START");
		//gameOn = true;
		StartCoroutine (RunGame ());
	}

	IEnumerator RunGame(){

		//Start of game
		//Delay to give view time to look around
		yield return new WaitForSeconds (10f);

		//Flicker and Crackle
		SoundEffects.GetComponent<SoundEffectManagerScript>().PlayLampCrackle();
		Lamp.GetComponent<LampScript> ().FlickerLamp ();
		yield return new WaitForSeconds (3f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffLampCrackle ();
		Lamp.GetComponent<LampScript> ().NormalLamp ();
		yield return new WaitForSeconds (1f);
		SoundEffects.GetComponent<SoundEffectManagerScript>().PlayLampCrackle();
		Lamp.GetComponent<LampScript> ().FlickerLamp ();
		yield return new WaitForSeconds (2f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffLampCrackle ();
		Lamp.GetComponent<LampScript> ().NormalLamp ();
		yield return new WaitForSeconds (2f);
		SoundEffects.GetComponent<SoundEffectManagerScript>().PlayLampCrackle();
		Lamp.GetComponent<LampScript> ().FlickerLamp ();
		yield return new WaitForSeconds (0.5f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffLampCrackle ();
		Lamp.GetComponent<LampScript> ().NormalLamp ();
		//end Flickerand Crackle


		//Lightning and Thunder
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayThunderSnap ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffLampCrackle ();
		LightningLight.GetComponent<LightingLightScript> ().LightingOn();
		yield return new WaitForSeconds (0.1f);
		LightningLight.GetComponent<LightingLightScript> ().LightingOff ();
		CeilingFan.GetComponent<CeilingFanScript>().IdleFan();
		OsFan.GetComponent<OSfanScript> ().IdleOSfan ();
		Lamp.GetComponent<LampScript> ().NormalLamp ();
		Lamp.GetComponent<LampScript> ().TurnOffLamp ();
		Clock.GetComponent<ClockScript> ().ClockIdlePendulum ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffClockTick ();
		yield return new WaitForSeconds (5f);
		//End Lightning and Thunder

		//Normal EM broadcast turns on
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayTvOn ();
		TV.GetComponent<TVScript> ().TurnOnEmergencyNormal ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayEMBStart ();
		ClosetLight.GetComponent<ClosetLightScript> ().SlowTurnOn ();
		yield return new WaitForSeconds (13f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffEMBStart ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffTvOn ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayEMBMessageTest ();
		yield return new WaitForSeconds (25.5f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffEMBMessageTest ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayEMBEnd ();
		yield return new WaitForSeconds (3f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffEMBEnd ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayTvOff ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffThunderSnap ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().WindVolumeDown (0f);
		TV.GetComponent<TVScript> ().TurnOffTV ();
		//End of EM broadcast sequence

		//start of closet thump and flicker
		yield return new WaitForSeconds (3f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayClosetThud ();
		yield return new WaitForSeconds (2f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffClosetThud ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffTvOff ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayClosetLightOff ();
		ClosetLight.GetComponent<ClosetLightScript> ().TurnOffClosetLight ();
		yield return new WaitForSeconds (2f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffClosetLightOff ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayClosetLightOn ();
		ClosetLight.GetComponent<ClosetLightScript> ().TurnOnClosetLight ();
		yield return new WaitForSeconds (2f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffClosetLightOn ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayClosetLightOff ();
		ClosetLight.GetComponent<ClosetLightScript> ().TurnOffClosetLight ();
		yield return new WaitForSeconds (2f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffClosetLightOff ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayClosetLightOn ();
		ClosetLight.GetComponent<ClosetLightScript> ().TurnOnClosetLight ();
		yield return new WaitForSeconds (2f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffClosetLightOn ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayClosetLightOff ();
		ClosetLight.GetComponent<ClosetLightScript> ().TurnOffClosetLight ();
		yield return new WaitForSeconds (2f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffClosetLightOff ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayClosetLightOn ();
		ClosetMonster.GetComponent<MonsterAppearScript> ().TurnMonsterOn ();
		ClosetLight.GetComponent<ClosetLightScript> ().TurnOnClosetLight ();
		yield return new WaitForSeconds (4f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffClosetLightOn ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayClosetLightOff ();
		ClosetLight.GetComponent<ClosetLightScript> ().TurnOffClosetLight ();
		ClosetMonster.GetComponent<MonsterAppearScript> ().TurnMonsterOff ();
		yield return new WaitForSeconds (3f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffClosetLightOff ();
		//end of close thump and flicker

		//Start closet door and steps
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayClosetDoorOpen ();
		ClosetDoor.GetComponent<ClosetDoorScript> ().SlowOpenCloset ();
		yield return new WaitForSeconds (3f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayFootStep1 ();
		yield return new WaitForSeconds (2f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayFootStep2 ();
		yield return new WaitForSeconds (2f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayFootStep3 ();
		yield return new WaitForSeconds (2f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayFootStep4 ();
		yield return new WaitForSeconds (2f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffFootStep1 ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffFootStep2 ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffFootStep3 ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffFootStep4 ();
		//end closet door and steps

		//thunderclap jump scare?
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayThunderSnapSmall ();
		LightningLight.GetComponent<LightingLightScript> ().LightingOn();
		DeskMonster.GetComponent<MonsterAppearScript> ().TurnMonsterOn ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().WindVolumeUp (0.01f);
		yield return new WaitForSeconds (0.2f);
		LightningLight.GetComponent<LightingLightScript> ().LightingOff ();
		DeskMonster.GetComponent<MonsterAppearScript> ().TurnMonsterOff ();
		yield return new WaitForSeconds (3f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayLightsOnSnap ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayClockTick ();
		Clock.GetComponent<ClockScript> ().ClockSwingPendulum ();
		CeilingFan.GetComponent<CeilingFanScript> ().FanOn ();
		CeilingFan.GetComponent<CeilingFanScript> ().NormalFanSpeed ();
		OsFan.GetComponent<OSfanScript> ().OSfanOn ();
		Lamp.GetComponent<LampScript> ().TurnOnLamp ();
		yield return new WaitForSeconds(8f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffLightsOnSnap ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffThunderSnapSmall ();
		//end thunder clap jump scare

		//Falling off Shelves


		//First Trophie Fall
		SoundEffects.GetComponent<SoundEffectManagerScript>().PlayLampCrackle();
		Lamp.GetComponent<LampScript> ().FlickerLamp ();
		yield return new WaitForSeconds (1f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffLampCrackle ();
		Lamp.GetComponent<LampScript> ().NormalLamp ();
		yield return new WaitForSeconds (1f);
		SoundEffects.GetComponent<SoundEffectManagerScript>().PlayLampCrackle();
		Lamp.GetComponent<LampScript> ().FlickerLamp ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayRattleSound ();
		Trophy.GetComponent<TrophyScript> ().TrophyShakeOnce ();
		yield return new WaitForSeconds (1f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffLampCrackle ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffRattleSound ();
		Lamp.GetComponent<LampScript> ().NormalLamp ();
		yield return new WaitForSeconds (2f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayRattleSound ();
		Trophy.GetComponent<TrophyScript> ().TrophyShakeOnce ();
		yield return new WaitForSeconds (3f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffRattleSound ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayRattleSound ();
		SoundEffects.GetComponent<SoundEffectManagerScript>().PlayLampCrackle();
		Lamp.GetComponent<LampScript> ().FlickerLamp ();
		Trophy.GetComponent<TrophyScript> ().TrophyShakeConstant ();
		yield return new WaitForSeconds (0.5f);
		SoundEffects.GetComponent<SoundEffectManagerScript>().PlayLampCrackle();
		Lamp.GetComponent<LampScript> ().FlickerLamp ();
		Trophy.GetComponent<TrophyScript> ().TrophyFall ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayTrophyBonk ();
		yield return new WaitForSeconds (1.5f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayTrophyBap ();
		yield return new WaitForSeconds (1f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffTrophyBonk ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffTrophyBap ();
		//End first trophie fall

		//chair squeak section

		//chair section 1
		yield return new WaitForSeconds (2f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayChairSqueakBack ();
		Chair.GetComponent<ChairScript> ().ChairCanRock ();
		yield return new WaitForSeconds (1f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffChairSqueakBack ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayChairSqueakForward ();
		Chair.GetComponent<ChairScript> ().ChairRockForward();
		yield return new WaitForSeconds (1f);
		//chair section 1 end

		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayTvWhispers (0.4f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayBookSlide ();
		Book6.GetComponent<BookFallScript> ().KnockOffBook ();

		//chair section 2
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffChairSqueakForward ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayChairSqueakBack ();
		Chair.GetComponent<ChairScript> ().ChairRockBackward ();
		Chair.GetComponent<ChairScript> ().ChairSpeedUp ();
		yield return new WaitForSeconds (0.8f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffChairSqueakBack ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayChairSqueakForward ();
		Chair.GetComponent<ChairScript> ().ChairRockForward();
		yield return new WaitForSeconds (0.6f);
		//chair section 2 end
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayBookBonk2();
		yield return new WaitForSeconds (0.2f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffBookSlide();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayTrophyBonk ();
		Trophy8.GetComponent<TrophyScript> ().TrophyFall ();

		//chair section 3
		Chair.GetComponent<ChairScript> ().ChairSpeedUp ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffChairSqueakForward ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayChairSqueakBack ();
		Chair.GetComponent<ChairScript> ().ChairRockBackward ();
		yield return new WaitForSeconds (0.6f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffChairSqueakBack ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayChairSqueakForward ();
		Chair.GetComponent<ChairScript> ().ChairRockForward();
		yield return new WaitForSeconds (0.6f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayPictureThrow ();
		PictureFrame2.GetComponent<PictureFrame2Script> ().PictureFrame2Fall ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffBookBonk ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayBookSlide ();
		Book7.GetComponent<BookFallScript> ().KnockOffBook ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffChairSqueakForward ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayChairSqueakBack ();
		Chair.GetComponent<ChairScript> ().ChairRockBackward ();
		yield return new WaitForSeconds (0.3f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayTrophyBap2 ();
		yield return new WaitForSeconds (0.3f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayLampCrackle ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffChairSqueakBack ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayChairSqueakForward ();
		Chair.GetComponent<ChairScript> ().ChairRockForward();
		//adjusted time for glass break
		yield return new WaitForSeconds (0.2f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayGlassBreak ();
		yield return new WaitForSeconds (0.4f);
		//Lamp starts DIM
		Lamp.GetComponent<LampScript> ().LampDim ();
		//end time adjust
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffChairSqueakForward ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayChairSqueakBack ();
		Chair.GetComponent<ChairScript> ().ChairRockBackward ();
		yield return new WaitForSeconds (0.3f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayBookBonk ();
		yield return new WaitForSeconds (0.3f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffBookSlide();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffChairSqueakBack ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayChairSqueakForward ();
		Chair.GetComponent<ChairScript> ().ChairRockForward();
		yield return new WaitForSeconds (0.6f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffBookBonk ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffGlassBreak ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffPictureThrow ();
		//chair section 3 end

		//chair section 4
		Chair.GetComponent<ChairScript> ().ChairSpeedUp ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffChairSqueakForward ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayChairSqueakBack ();
		Chair.GetComponent<ChairScript> ().ChairRockBackward ();
		yield return new WaitForSeconds (0.4f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffLampCrackle ();
		//Lamp ends Dim
		SoundEffects.GetComponent<SoundEffectManagerScript> ().WindVolumeUp (0.02f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffChairSqueakBack ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayChairSqueakForward ();
		Chair.GetComponent<ChairScript> ().ChairRockForward();
		yield return new WaitForSeconds (0.4f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffChairSqueakForward ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayChairSqueakBack ();
		Chair.GetComponent<ChairScript> ().ChairRockBackward ();
		yield return new WaitForSeconds (0.4f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffChairSqueakBack ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayChairSqueakForward ();
		Chair.GetComponent<ChairScript> ().ChairRockForward();
		yield return new WaitForSeconds (0.4f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffChairSqueakForward ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayChairSqueakBack ();
		Chair.GetComponent<ChairScript> ().ChairRockBackward ();
		yield return new WaitForSeconds (0.4f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffChairSqueakBack ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayChairSqueakForward ();
		Chair.GetComponent<ChairScript> ().ChairRockForward();
		yield return new WaitForSeconds (0.4f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffChairSqueakForward ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayChairSqueakBack ();
		Chair.GetComponent<ChairScript> ().ChairRockBackward ();
		yield return new WaitForSeconds (0.4f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffChairSqueakBack ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayChairSqueakForward ();
		Chair.GetComponent<ChairScript> ().ChairRockForward();
		yield return new WaitForSeconds (0.4f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffChairSqueakForward ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayChairSqueakBack ();
		Chair.GetComponent<ChairScript> ().ChairRockBackward ();
		yield return new WaitForSeconds (0.4f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffChairSqueakBack ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayChairSqueakForward ();
		Chair.GetComponent<ChairScript> ().ChairRockForward();
		yield return new WaitForSeconds (0.4f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffChairSqueakForward ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayChairSqueakBack ();
		//Chair.GetComponent<ChairScript> ().ChairRockBackward ();
		Chair.GetComponent<ChairScript> ().ChairIdle ();
		yield return new WaitForSeconds (0.4f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffChairSqueakBack ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayChairSqueakForward ();
		//Chair.GetComponent<ChairScript> ().ChairRockForward();
		Chair.GetComponent<ChairScript> ().ChairSpinSet ();
		yield return new WaitForSeconds (0.4f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffChairSqueakForward ();
		//Chair.GetComponent<ChairScript> ().ChairIdle ();
		Chair.GetComponent<ChairScript> ().ChairSpeedNormal ();
		Chair.GetComponent<ChairScript> ().ChairTurnOff ();
		ChairMonster.SetActive (true);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffTrophyBonk ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffTrophyBap ();
		//chair section 4 end
		//end chair squeak section

		//chair spin and monster
		SoundEffects.GetComponent<SoundEffectManagerScript>().PlayThunderSnapSmall();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().WindVolumeDown (0f);
		LightningLight.GetComponent<LightingLightScript> ().LightingOn();
		yield return new WaitForSeconds (0.4f);
		LightningLight.GetComponent<LightingLightScript> ().LightingOff ();
		ChairMonster.SetActive (false);
		Chair.GetComponent<ChairScript> ().ChairTurnOn ();
		yield return new WaitForSeconds (4f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayChairTwistSqueak ();
		Chair.GetComponent<ChairScript> ().ChairSpin ();
		yield return new WaitForSeconds (0.1f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayFootStep4 ();
		yield return new WaitForSeconds (0.2f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayFootStep3 ();
		yield return new WaitForSeconds (0.2f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayFootStep2 ();
		yield return new WaitForSeconds (0.2f);
		Lamp.GetComponent<LampScript> ().NormalLamp ();
		Lamp.GetComponent<LampScript> ().TurnOnLamp ();
		yield return new WaitForSeconds (2f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffChairTwistSqeuak ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffFootStep2 ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffFootStep3 ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffFootStep4 ();
		//end chair spin and monster


		//pre room goes crazy event
		yield return new WaitForSeconds (6f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().WindVolumeDown (0f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayRandomLeftSideBump ();
		yield return new WaitForSeconds (3f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayRandomRightSideBump ();
		yield return new WaitForSeconds (3f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffRandomLeftSideBump ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffRandomRightSideBump ();
		SoundEffects.GetComponent<SoundEffectManagerScript>().TurnOffThunderSnapSmall();
		yield return new WaitForSeconds (1f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayRemoteShake ();
		Remote.GetComponent<TvRemoteScript> ().TvRemoteTwitch ();
		yield return new WaitForSeconds (2f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffRemoteShake ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayRemoteShake ();
		Remote.GetComponent<TvRemoteScript> ().TvRemoteTwitch ();
		yield return new WaitForSeconds (1f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayNSOpen ();
		NightStandTop.GetComponent<NightStandTopScript> ().OpenNSTop ();
		yield return new WaitForSeconds (3f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffRemoteShake ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayRemoteSlide ();
		Remote.GetComponent<TvRemoteScript> ().TvRemoteSlide ();
		yield return new WaitForSeconds (4.5f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayRemoteBap ();
		yield return new WaitForSeconds (0.6f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffRemoteShake ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffRemoteSlide ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffRemoteBap ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayNSSlam ();
		NightStandTop.GetComponent<NightStandTopScript> ().CloseNSTop ();
		yield return new WaitForSeconds (1f);
		NightStandTop.GetComponent<NightStandTopScript> ().IdleNStop ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffNSSlam ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffNSOpen ();
		//end pre room goes crazy event

		//prelamp crackling
		yield return new WaitForSeconds (1f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayLampCrackle ();
		Lamp.GetComponent<LampScript> ().FlickerLamp ();
		yield return new WaitForSeconds (0.9f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffLampCrackle ();
		Lamp.GetComponent<LampScript> ().NormalLamp ();
		yield return new WaitForSeconds (0.4f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayLampCrackle ();
		Lamp.GetComponent<LampScript> ().FlickerLamp ();
		yield return new WaitForSeconds (0.7f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffLampCrackle ();
		Lamp.GetComponent<LampScript> ().NormalLamp ();
		yield return new WaitForSeconds (0.3f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayLampCrackle ();
		Lamp.GetComponent<LampScript> ().FlickerLamp ();
		yield return new WaitForSeconds (0.5f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayLightsOnSnap ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffLampCrackle ();
		Lamp.GetComponent<LampScript> ().NormalLamp ();
		Lamp.GetComponent<LampScript> ().TurnOffLamp ();

		//end pre lamp crackling


		//Room goes crazy and Monster appears at bed
		//Pre room build
		yield return new WaitForSeconds (0.1f);
		RubixCube.GetComponent<RubixCubeScript> ().ShakeRubixCube ();
		WaterGlass.GetComponent<WaterGlassScript> ().ShakeWaterGlass ();
		LaundryBasket.GetComponent<LaundryBasketScript> ().ShakeLaundryBasket ();
		ClockHands.GetComponent<ClockHandsSCript> ().SpinClockHands ();
		TissueBox.GetComponent<TissueBoxScript> ().ShakeTissueBox ();
		WhiteBoard.GetComponent<WhiteBoardScript> ().ShakeWhiteBoard ();
		FishBowl.GetComponent<FishBowlScript> ().ShakeFishBowl ();
		Trophy1.GetComponent<TrophyScript> ().TrophyShakeConstant ();
		Trophy6.GetComponent<TrophyScript> ().TrophyShakeConstant ();
		Trophy7.GetComponent<TrophyScript> ().TrophyShakeConstant ();
		Picture1.GetComponent<PictureScript> ().PictureSwing ();
		ClosetDoor.GetComponent<ClosetDoorScript> ().OpenCloseCloset ();
		DresserTop.GetComponent<DresserTopScript> ().OpenCloseTop ();
		DeskBot.GetComponent<DeskBotScript> ().OpenCloseDeskBot ();
		DresserMid.GetComponent<DresserMidScript> ().OpenCloseMid ();
		CeilingFan.GetComponent<CeilingFanScript> ().FanOn ();
		CeilingFan.GetComponent<CeilingFanScript> ().FastFanSpeed ();
		OsFan.GetComponent<OSfanScript> ().OSfanOnFast ();
		Picture2.GetComponent<PictureScript> ().PictureSwing ();
		NightStandTop.GetComponent<NightStandTopScript> ().OpenCloseNStop ();
		DeskTop.GetComponent<DeskTopScript> ().OpenCloseDeskTop ();
		DresserBot.GetComponent<DresserBotScript> ().OpenCloseBot ();
		yield return new WaitForSeconds (1f);
		//end pre room build

		//tv and lamp come on and flicker
		SoundEffects.GetComponent<SoundEffectManagerScript> ().WindVolumeUp (0.01f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffLightsOnSnap();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayTvOn ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayEMBConstant ();
		TV.GetComponent<TVScript> ().TurnOnEmergencyNormal ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayRattleSoundLong ();
		//SoundEffects.GetComponent<SoundEffectManagerScript> ().PLayClutterNoise ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayLampCrackle ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayClosetDoorCloseOpen ();
		Lamp.GetComponent<LampScript> ().FlickerLamp ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayClosetWhispers (0.6f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayTvWhispers (0.6f);
		ClosetLight.GetComponent<ClosetLightScript> ().FlickerClosetLight ();
		//let player look around at room going crazy
		yield return new WaitForSeconds (5f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffTvOn ();
		yield return new WaitForSeconds (3f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayRandomItemsBonkLeft ();
		while (pileNumber < 6) {
			PileOfThings [pileNumber].GetComponent<ExplodeObjectsScript> ().ExplodeObjects ();
			pileNumber++;
		}
		yield return new WaitForSeconds (2f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayRandomItemsBonkRight ();
		while (pileNumber < 12) {
			PileOfThings [pileNumber].GetComponent<ExplodeObjectsScript> ().ExplodeObjects ();
			pileNumber++;
		}
		yield return new WaitForSeconds (1.2f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffRandomItemsBonkLeft ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffRandomItemsBonkRight ();
		//end player time to look around room

		//start bed crawl monster
		BedFootCrawlMonster.SetActive (true);
		yield return new WaitForSeconds (0.8f);
		SoundEffects.GetComponent<SoundEffectManagerScript>().PlayThunderSnapSmall();
		LightningLight.GetComponent<LightingLightScript> ().LightingOn ();
		yield return new WaitForSeconds (0.2f);
		LightningLight.GetComponent<LightingLightScript> ().LightingOff ();
		Lamp.GetComponent<LampScript> ().NormalLamp ();
		Lamp.GetComponent<LampScript> ().TurnOffLamp ();
		ClosetLight.GetComponent<ClosetLightScript> ().TurnOffClosetLight ();
		ClosetLight.GetComponent<ClosetLightScript> ().NormalClosetLight ();
		TV.GetComponent<TVScript> ().TurnOffTV ();
		//end bed crawl monster
		//start bed foot monster
		BedFootCrawlMonster.SetActive (false);
		BedFootMonster.GetComponent<MonsterAppearScript> ().TurnMonsterOn ();
		yield return new WaitForSeconds (0.5f);
		//MonsterAppears
		ClosetLight.GetComponent<ClosetLightScript> ().FlickerClosetLight ();
		ClosetLight.GetComponent<ClosetLightScript> ().TurnOnClosetLight ();
		Lamp.GetComponent<LampScript> ().TurnOnLampHalf ();
		Lamp.GetComponent<LampScript> ().FlickerLamp ();
		TV.GetComponent<TVScript> ().TurnOnEmergencyNormal ();
		yield return new WaitForSeconds (3f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffThunderSnapSmall ();
		SoundEffects.GetComponent<SoundEffectManagerScript>().PlayThunderSnapSmall();
		LightningLight.GetComponent<LightingLightScript> ().LightingOn ();
		yield return new WaitForSeconds (0.2f);
		LightningLight.GetComponent<LightingLightScript> ().LightingOff ();
		Lamp.GetComponent<LampScript> ().NormalLamp ();
		Lamp.GetComponent<LampScript> ().TurnOffLamp ();
		ClosetLight.GetComponent<ClosetLightScript> ().TurnOffClosetLight ();
		ClosetLight.GetComponent<ClosetLightScript> ().NormalClosetLight ();
		TV.GetComponent<TVScript> ().TurnOffTV ();
		BedFootMonster.GetComponent<MonsterAppearScript> ().TurnMonsterOff ();
		//end bed foot monster
		//start on bed mosnter
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayMonsterBedWhispers();
		BedMonster.GetComponent<MonsterAppearScript> ().TurnMonsterOn ();
		BedMonster.GetComponent<BedMonsterScript> ().BedMonsterHeadShake ();
		yield return new WaitForSeconds (0.5f);
		ClosetLight.GetComponent<ClosetLightScript> ().FlickerClosetLight ();
		ClosetLight.GetComponent<ClosetLightScript> ().TurnOnClosetLight ();
		Lamp.GetComponent<LampScript> ().TurnOnLampHalf ();
		Lamp.GetComponent<LampScript> ().FlickerLamp ();
		TV.GetComponent<TVScript> ().TurnOnEmergencyNormal ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().WindVolumeDown (0f);
		yield return new WaitForSeconds (1.5f);
		//Monster Disappears
		//chill out room
		BedMonster.GetComponent<MonsterAppearScript>().TurnMonsterOff();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffMonsterBedWhispers ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayLightsOnSnap ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffRattleSoundLong();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffEMBConstant ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayTvOff ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffLampCrackle ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffClosetWhispers ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffTvWhispers ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffClosetDoorCloseOpen ();
		TV.GetComponent<TVScript> ().TurnOffTV ();
		RubixCube.GetComponent<RubixCubeScript> ().IdleRubixCube ();
		WaterGlass.GetComponent<WaterGlassScript> ().IdleWaterGlass ();
		LaundryBasket.GetComponent<LaundryBasketScript> ().IdleLaundryBasket ();
		ClockHands.GetComponent<ClockHandsSCript> ().IdleClockHands ();
		TissueBox.GetComponent<TissueBoxScript> ().IdleTissueBox ();
		WhiteBoard.GetComponent<WhiteBoardScript> ().IdleWhiteBoard ();
		FishBowl.GetComponent<FishBowlScript> ().IdleFishBowl ();
		ClosetLight.GetComponent<ClosetLightScript> ().TurnOffClosetLight ();
		ClosetLight.GetComponent<ClosetLightScript> ().NormalClosetLight ();
		Lamp.GetComponent<LampScript> ().TurnOffLamp ();
		Lamp.GetComponent<LampScript> ().NormalLamp ();
		Trophy1.GetComponent<TrophyScript> ().TrophyIdle ();
		Trophy6.GetComponent<TrophyScript> ().TrophyIdle ();
		Trophy7.GetComponent<TrophyScript> ().TrophyIdle ();
		ClosetDoor.GetComponent<ClosetDoorScript> ().CloseCloset ();
		DresserTop.GetComponent<DresserTopScript> ().IdleTop ();
		DresserBot.GetComponent<DresserBotScript> ().IdleBot ();
		DresserMid.GetComponent<DresserMidScript> ().IdleMid ();
		NightStandTop.GetComponent<NightStandTopScript> ().IdleNStop ();
		DeskBot.GetComponent<DeskBotScript> ().IdleDeskBot ();
		DeskTop.GetComponent<DeskTopScript> ().IdleDeskTop ();
		CeilingFan.GetComponent<CeilingFanScript> ().IdleFan ();
		OsFan.GetComponent<OSfanScript> ().IdleOSfan ();
		Picture1.GetComponent<PictureScript> ().PictureIdle ();
		Picture2.GetComponent<PictureScript> ().PictureIdle ();
		yield return new WaitForSeconds (1f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffLightsOnSnap ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffTvOff ();
		ClosetDoor.GetComponent<ClosetDoorScript> ().IdleCloset ();
		yield return new WaitForSeconds (6f);

		//end room goes crazy and monster appears at bed

		//Emergency Broadcast death
		yield return new WaitForSeconds (2f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayTvOn ();
		TV.GetComponent<TVScript> ().TurnOnEmergencyEnd ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayEMBStart ();
		yield return new WaitForSeconds (13f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffEMBStart ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffTvOn ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayEMBDeathMessage ();
		yield return new WaitForSeconds (9.5f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffEMBDeathMessage ();
//		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayEMBEnd ();
//		yield return new WaitForSeconds (3f);
//		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffEMBEnd ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayTvOff ();
		TV.GetComponent<TVScript> ().TurnOffTV ();
		yield return new WaitForSeconds (1f);
		BedsideMonster.GetComponent<MonsterAppearScript> ().TurnMonsterOn ();
		BedsideMonster.GetComponent<BedsideMonsterScript> ().AllowMonsterPop ();
		BedsideMonsterTrigger.SetActive (true);
		CeilingFan.GetComponent<CeilingFanScript> ().FanOn ();
		CeilingFan.GetComponent<CeilingFanScript> ().NormalFanSpeed ();
		OsFan.GetComponent<OSfanScript> ().OSfanOn ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayLightsOnSnap ();
		Lamp.GetComponent<LampScript> ().TurnOnLamp ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffThunderSnapSmall ();
		yield return new WaitForSeconds (1f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffLightsOnSnap ();
		SoundEffects.GetComponent<SoundEffectManagerScript> ().TurnOffTvOff ();
		yield return new WaitForSeconds (2f);
		SoundEffects.GetComponent<SoundEffectManagerScript> ().PlayDoorCreak ();
		BedroomDoor.GetComponent<BedroomDoorScript> ().OpenBedRoomDoor ();

		//end shuffling to side of bed and monster leap

		//Debug.Log ("GAME OVER");
	}
}