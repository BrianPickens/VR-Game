using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimelineScript : MonoBehaviour {

	//delete this after release
	public bool runGame;
	//end delete after release

	//private bool gameOn;

	[SerializeField]
	private CameraBlackOut BlackOut = null;


	public SoundEffectManagerScript SoundEffectsObject;
	public LampScript LampObject;
	public LightingLightScript LightningLightObject;
	public ClosetLightScript ClosetLightObject;
	public ClosetDoorScript ClosetDoorObject;
	public CeilingFanScript CeilingFanObject;
	public OSfanScript OsFanObject;
	public DresserTopScript DresserTopObject;
	public DresserBotScript DresserBotObject;
	public DresserMidScript DresserMidObject;
	public NightStandTopScript NightStandTopObject;
	public DeskTopScript DeskTopObject;
	public DeskBotScript DeskBotObject;
	public TVScript TVObject;
	public TrophyScript TrophyObject;
	public TrophyScript Trophy1Object;
	public TrophyScript Trophy6Object;
	public TrophyScript Trophy7Object;
	public TrophyScript Trophy8Object;
	public BookFallScript Book6Object;
	public BookFallScript Book7Object;
	public ChairScript ChairObject;
	public PictureScript Picture1Object;
	public PictureScript Picture2Object;
	public PictureFrame2Script PictureFrame2Object;
	public TvRemoteScript RemoteObject;
	public ClockScript ClockObject;
	public RubixCubeScript RubixCubeObject;
	public WaterGlassScript WaterGlassObject;
	public LaundryBasketScript LaundryBasketObject;
	public ClockHandsSCript ClockHandsObject;
	public TissueBoxScript TissueBoxObject;
	public WhiteBoardScript WhiteBoardObject;
	public FishBowlScript FishBowlObject;
	public BedroomDoorScript BedroomDoorObject;

	public ExplodeObjectsScript[] PileOfThingsObjects;
	private int pileNumber;


	public GameObject ChairMonster;
	public MonsterAppearScript ClosetMonsterObject;
	public MonsterAppearScript DeskMonsterObject;
	public MonsterAppearScript BedFootMonsterObject;
	public GameObject BedFootCrawlMonster;
	public GameObject BedsideMonster;
	public GameObject BedMonster;
	public GameObject BedsideMonsterTrigger;

	private float timeLapsed;

	// Use this for initialization
	void Start () {
		//delete the if after release

		BlackOut.FadeOutBlocker();

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
		yield return new WaitForSeconds(10f);

		//Flicker and Crackle
		SoundEffectsObject.PlayLampCrackle();
		LampObject.FlickerLamp();
		yield return new WaitForSeconds(3f);
		SoundEffectsObject.TurnOffLampCrackle();
		LampObject.NormalLamp();
		yield return new WaitForSeconds(1f);
		SoundEffectsObject.PlayLampCrackle();
		LampObject.FlickerLamp();
		yield return new WaitForSeconds(2f);
		SoundEffectsObject.TurnOffLampCrackle();
		LampObject.NormalLamp();
		yield return new WaitForSeconds(2f);
		SoundEffectsObject.PlayLampCrackle();
		LampObject.FlickerLamp();
		yield return new WaitForSeconds(0.5f);
		SoundEffectsObject.TurnOffLampCrackle();
		LampObject.NormalLamp();
		//end Flickerand Crackle


		//Lightning and Thunder
		SoundEffectsObject.PlayThunderSnap();
		SoundEffectsObject.TurnOffLampCrackle();
		LightningLightObject.LightingOn();
		yield return new WaitForSeconds(0.1f);
		LightningLightObject.LightingOff();
		CeilingFanObject.IdleFan();
		OsFanObject.IdleOSfan();
		LampObject.NormalLamp();
		LampObject.TurnOffLamp();
		ClockObject.ClockIdlePendulum();
		SoundEffectsObject.TurnOffClockTick();
		yield return new WaitForSeconds(5f);
		//End Lightning and Thunder

		//Normal EM broadcast turns on
		SoundEffectsObject.PlayTvOn();
		TVObject.TurnOnEmergencyNormal();
		SoundEffectsObject.PlayEMBStart();
		ClosetLightObject.SlowTurnOn();
		yield return new WaitForSeconds(13f);
		SoundEffectsObject.TurnOffEMBStart();
		SoundEffectsObject.TurnOffTvOn();
		SoundEffectsObject.PlayEMBMessageTest();
		yield return new WaitForSeconds(25.5f);
		SoundEffectsObject.TurnOffEMBMessageTest();
		SoundEffectsObject.PlayEMBEnd();
		yield return new WaitForSeconds(3f);
		SoundEffectsObject.TurnOffEMBEnd();
		SoundEffectsObject.PlayTvOff();
		SoundEffectsObject.TurnOffThunderSnap();
		SoundEffectsObject.WindVolumeDown(0f);
		TVObject.TurnOffTV();
		//End of EM broadcast sequence

		//start of closet thump and flicker
		yield return new WaitForSeconds(3f);
		SoundEffectsObject.PlayClosetThud();
		yield return new WaitForSeconds(2f);
		SoundEffectsObject.TurnOffClosetThud();
		SoundEffectsObject.TurnOffTvOff();
		SoundEffectsObject.PlayClosetLightOff();
		ClosetLightObject.TurnOffClosetLight();
		yield return new WaitForSeconds(2f);
		SoundEffectsObject.TurnOffClosetLightOff();
		SoundEffectsObject.PlayClosetLightOn();
		ClosetLightObject.TurnOnClosetLight();
		yield return new WaitForSeconds(2f);
		SoundEffectsObject.TurnOffClosetLightOn();
		SoundEffectsObject.PlayClosetLightOff();
		ClosetLightObject.TurnOffClosetLight();
		yield return new WaitForSeconds(2f);
		SoundEffectsObject.TurnOffClosetLightOff();
		SoundEffectsObject.PlayClosetLightOn();
		ClosetLightObject.TurnOnClosetLight();
		yield return new WaitForSeconds(2f);
		SoundEffectsObject.TurnOffClosetLightOn();
		SoundEffectsObject.PlayClosetLightOff();
		ClosetLightObject.TurnOffClosetLight();
		yield return new WaitForSeconds(2f);
		SoundEffectsObject.TurnOffClosetLightOff();
		SoundEffectsObject.PlayClosetLightOn();
		ClosetMonsterObject.TurnMonsterOn();
		ClosetLightObject.TurnOnClosetLight();
		yield return new WaitForSeconds(4f);
		SoundEffectsObject.TurnOffClosetLightOn();
		SoundEffectsObject.PlayClosetLightOff();
		ClosetLightObject.TurnOffClosetLight();
		ClosetMonsterObject.TurnMonsterOff();
		yield return new WaitForSeconds(3f);
		SoundEffectsObject.TurnOffClosetLightOff();
		//end of close thump and flicker

		//Start closet door and steps
		SoundEffectsObject.PlayClosetDoorOpen();
		ClosetDoorObject.SlowOpenCloset();
		yield return new WaitForSeconds(3f);
		SoundEffectsObject.PlayFootStep1();
		yield return new WaitForSeconds(2f);
		SoundEffectsObject.PlayFootStep2();
		yield return new WaitForSeconds(2f);
		SoundEffectsObject.PlayFootStep3();
		yield return new WaitForSeconds(2f);
		SoundEffectsObject.PlayFootStep4();
		yield return new WaitForSeconds(2f);
		SoundEffectsObject.TurnOffFootStep1();
		SoundEffectsObject.TurnOffFootStep2();
		SoundEffectsObject.TurnOffFootStep3();
		SoundEffectsObject.TurnOffFootStep4();
		//end closet door and steps

		//thunderclap jump scare?
		SoundEffectsObject.PlayThunderSnapSmall();
		LightningLightObject.LightingOn();
		DeskMonsterObject.TurnMonsterOn();
		SoundEffectsObject.WindVolumeUp(0.01f);
		yield return new WaitForSeconds(0.2f);
		LightningLightObject.LightingOff();
		DeskMonsterObject.TurnMonsterOff();
		yield return new WaitForSeconds(3f);
		SoundEffectsObject.PlayLightsOnSnap();
		SoundEffectsObject.PlayClockTick();
		ClockObject.ClockSwingPendulum();
		CeilingFanObject.FanOn();
		CeilingFanObject.NormalFanSpeed();
		OsFanObject.OSfanOn();
		LampObject.TurnOnLamp();
		yield return new WaitForSeconds(8f);
		SoundEffectsObject.TurnOffLightsOnSnap();
		SoundEffectsObject.TurnOffThunderSnapSmall();
		//end thunder clap jump scare

		//Falling off Shelves


		//First Trophie Fall
		SoundEffectsObject.PlayLampCrackle();
		LampObject.FlickerLamp();
		yield return new WaitForSeconds(1f);
		SoundEffectsObject.TurnOffLampCrackle();
		LampObject.NormalLamp();
		yield return new WaitForSeconds(1f);
		SoundEffectsObject.PlayLampCrackle();
		LampObject.FlickerLamp();
		SoundEffectsObject.PlayRattleSound();
		TrophyObject.TrophyShakeOnce();
		yield return new WaitForSeconds(1f);
		SoundEffectsObject.TurnOffLampCrackle();
		SoundEffectsObject.TurnOffRattleSound();
		LampObject.NormalLamp();
		yield return new WaitForSeconds(2f);
		SoundEffectsObject.PlayRattleSound();
		TrophyObject.TrophyShakeOnce();
		yield return new WaitForSeconds(3f);
		SoundEffectsObject.TurnOffRattleSound();
		SoundEffectsObject.PlayRattleSound();
		SoundEffectsObject.PlayLampCrackle();
		LampObject.FlickerLamp();
		TrophyObject.TrophyShakeConstant();
		yield return new WaitForSeconds(0.5f);
		SoundEffectsObject.PlayLampCrackle();
		LampObject.FlickerLamp();
		TrophyObject.TrophyFall();
		SoundEffectsObject.PlayTrophyBonk();
		yield return new WaitForSeconds(1.5f);
		SoundEffectsObject.PlayTrophyBap();
		yield return new WaitForSeconds(1f);
		SoundEffectsObject.TurnOffTrophyBonk();
		SoundEffectsObject.TurnOffTrophyBap();
		//End first trophie fall

		//chair squeak section

		//chair section 1
		yield return new WaitForSeconds(2f);
		SoundEffectsObject.PlayChairSqueakBack();
		ChairObject.ChairCanRock();
		yield return new WaitForSeconds(1f);
		SoundEffectsObject.TurnOffChairSqueakBack();
		SoundEffectsObject.PlayChairSqueakForward();
		ChairObject.ChairRockForward();
		yield return new WaitForSeconds(1f);
		//chair section 1 end

		SoundEffectsObject.PlayTvWhispers(0.4f);
		SoundEffectsObject.PlayBookSlide();
		Book6Object.KnockOffBook();

		//chair section 2
		SoundEffectsObject.TurnOffChairSqueakForward();
		SoundEffectsObject.PlayChairSqueakBack();
		ChairObject.ChairRockBackward();
		ChairObject.ChairSpeedUp();
		yield return new WaitForSeconds(0.8f);
		SoundEffectsObject.TurnOffChairSqueakBack();
		SoundEffectsObject.PlayChairSqueakForward();
		ChairObject.ChairRockForward();
		yield return new WaitForSeconds(0.6f);
		//chair section 2 end
		SoundEffectsObject.PlayBookBonk2();
		yield return new WaitForSeconds(0.2f);
		SoundEffectsObject.TurnOffBookSlide();
		SoundEffectsObject.PlayTrophyBonk();
		Trophy8Object.TrophyFall();

		//chair section 3
		ChairObject.ChairSpeedUp();
		SoundEffectsObject.TurnOffChairSqueakForward();
		SoundEffectsObject.PlayChairSqueakBack();
		ChairObject.ChairRockBackward();
		yield return new WaitForSeconds(0.6f);
		SoundEffectsObject.TurnOffChairSqueakBack();
		SoundEffectsObject.PlayChairSqueakForward();
		ChairObject.ChairRockForward();
		yield return new WaitForSeconds(0.6f);
		SoundEffectsObject.PlayPictureThrow();
		PictureFrame2Object.PictureFrame2Fall();
		SoundEffectsObject.TurnOffBookBonk();
		SoundEffectsObject.PlayBookSlide();
		Book7Object.KnockOffBook();
		SoundEffectsObject.TurnOffChairSqueakForward();
		SoundEffectsObject.PlayChairSqueakBack();
		ChairObject.ChairRockBackward();
		yield return new WaitForSeconds(0.3f);
		SoundEffectsObject.PlayTrophyBap2();
		yield return new WaitForSeconds(0.3f);
		SoundEffectsObject.PlayLampCrackle();
		SoundEffectsObject.TurnOffChairSqueakBack();
		SoundEffectsObject.PlayChairSqueakForward();
		ChairObject.ChairRockForward();
		//adjusted time for glass break
		yield return new WaitForSeconds(0.2f);
		SoundEffectsObject.PlayGlassBreak();
		yield return new WaitForSeconds(0.4f);
		//Lamp starts DIM
		LampObject.LampDim();
		//end time adjust
		SoundEffectsObject.TurnOffChairSqueakForward();
		SoundEffectsObject.PlayChairSqueakBack();
		ChairObject.ChairRockBackward();
		yield return new WaitForSeconds(0.3f);
		SoundEffectsObject.PlayBookBonk();
		yield return new WaitForSeconds(0.3f);
		SoundEffectsObject.TurnOffBookSlide();
		SoundEffectsObject.TurnOffChairSqueakBack();
		SoundEffectsObject.PlayChairSqueakForward();
		ChairObject.ChairRockForward();
		yield return new WaitForSeconds(0.6f);
		SoundEffectsObject.TurnOffBookBonk();
		SoundEffectsObject.TurnOffGlassBreak();
		SoundEffectsObject.TurnOffPictureThrow();
		//chair section 3 end

		//chair section 4
		ChairObject.ChairSpeedUp();
		SoundEffectsObject.TurnOffChairSqueakForward();
		SoundEffectsObject.PlayChairSqueakBack();
		ChairObject.ChairRockBackward();
		yield return new WaitForSeconds(0.4f);
		SoundEffectsObject.TurnOffLampCrackle();
		//Lamp ends Dim
		SoundEffectsObject.WindVolumeUp(0.02f);
		SoundEffectsObject.TurnOffChairSqueakBack();
		SoundEffectsObject.PlayChairSqueakForward();
		ChairObject.ChairRockForward();
		yield return new WaitForSeconds(0.4f);
		SoundEffectsObject.TurnOffChairSqueakForward();
		SoundEffectsObject.PlayChairSqueakBack();
		ChairObject.ChairRockBackward();
		yield return new WaitForSeconds(0.4f);
		SoundEffectsObject.TurnOffChairSqueakBack();
		SoundEffectsObject.PlayChairSqueakForward();
		ChairObject.ChairRockForward();
		yield return new WaitForSeconds(0.4f);
		SoundEffectsObject.TurnOffChairSqueakForward();
		SoundEffectsObject.PlayChairSqueakBack();
		ChairObject.ChairRockBackward();
		yield return new WaitForSeconds(0.4f);
		SoundEffectsObject.TurnOffChairSqueakBack();
		SoundEffectsObject.PlayChairSqueakForward();
		ChairObject.ChairRockForward();
		yield return new WaitForSeconds(0.4f);
		SoundEffectsObject.TurnOffChairSqueakForward();
		SoundEffectsObject.PlayChairSqueakBack();
		ChairObject.ChairRockBackward();
		yield return new WaitForSeconds(0.4f);
		SoundEffectsObject.TurnOffChairSqueakBack();
		SoundEffectsObject.PlayChairSqueakForward();
		ChairObject.ChairRockForward();
		yield return new WaitForSeconds(0.4f);
		SoundEffectsObject.TurnOffChairSqueakForward();
		SoundEffectsObject.PlayChairSqueakBack();
		ChairObject.ChairRockBackward();
		yield return new WaitForSeconds(0.4f);
		SoundEffectsObject.TurnOffChairSqueakBack();
		SoundEffectsObject.PlayChairSqueakForward();
		ChairObject.ChairRockForward();
		yield return new WaitForSeconds(0.4f);
		SoundEffectsObject.TurnOffChairSqueakForward();
		SoundEffectsObject.PlayChairSqueakBack();
		//ChairObject.ChairRockBackward ();
		ChairObject.ChairIdle();
		yield return new WaitForSeconds(0.4f);
		SoundEffectsObject.TurnOffChairSqueakBack();
		SoundEffectsObject.PlayChairSqueakForward();
		//ChairObject.ChairRockForward();
		ChairObject.ChairSpinSet();
		yield return new WaitForSeconds(0.4f);
		SoundEffectsObject.TurnOffChairSqueakForward();
		//ChairObject.ChairIdle ();
		ChairObject.ChairSpeedNormal();
		ChairObject.ChairTurnOff();
		ChairMonster.SetActive(true);
		SoundEffectsObject.TurnOffTrophyBonk();
		SoundEffectsObject.TurnOffTrophyBap();
		//chair section 4 end
		//end chair squeak section

		//chair spin and monster
		SoundEffectsObject.PlayThunderSnapSmall();
		SoundEffectsObject.WindVolumeDown(0f);
		LightningLightObject.LightingOn();
		yield return new WaitForSeconds(0.4f);
		LightningLightObject.LightingOff();
		ChairMonster.SetActive(false);
		ChairObject.ChairTurnOn();
		yield return new WaitForSeconds(4f);
		SoundEffectsObject.PlayChairTwistSqueak();
		ChairObject.ChairSpin();
		yield return new WaitForSeconds(0.1f);
		SoundEffectsObject.PlayFootStep4();
		yield return new WaitForSeconds(0.2f);
		SoundEffectsObject.PlayFootStep3();
		yield return new WaitForSeconds(0.2f);
		SoundEffectsObject.PlayFootStep2();
		yield return new WaitForSeconds(0.2f);
		LampObject.NormalLamp();
		LampObject.TurnOnLamp();
		yield return new WaitForSeconds(2f);
		SoundEffectsObject.TurnOffChairTwistSqeuak();
		SoundEffectsObject.TurnOffFootStep2();
		SoundEffectsObject.TurnOffFootStep3();
		SoundEffectsObject.TurnOffFootStep4();
		//end chair spin and monster


		//pre room goes crazy event
		yield return new WaitForSeconds(6f);
		SoundEffectsObject.WindVolumeDown(0f);
		SoundEffectsObject.PlayRandomLeftSideBump();
		yield return new WaitForSeconds(3f);
		SoundEffectsObject.PlayRandomRightSideBump();
		yield return new WaitForSeconds(3f);
		SoundEffectsObject.TurnOffRandomLeftSideBump();
		SoundEffectsObject.TurnOffRandomRightSideBump();
		SoundEffectsObject.TurnOffThunderSnapSmall();
		yield return new WaitForSeconds(1f);
		SoundEffectsObject.PlayRemoteShake();
		RemoteObject.TvRemoteTwitch();
		yield return new WaitForSeconds(2f);
		SoundEffectsObject.TurnOffRemoteShake();
		SoundEffectsObject.PlayRemoteShake();
		RemoteObject.TvRemoteTwitch();
		yield return new WaitForSeconds(1f);
		SoundEffectsObject.PlayNSOpen();
		NightStandTopObject.OpenNSTop();
		yield return new WaitForSeconds(3f);
		SoundEffectsObject.TurnOffRemoteShake();
		SoundEffectsObject.PlayRemoteSlide();
		RemoteObject.TvRemoteSlide();
		yield return new WaitForSeconds(4.5f);
		SoundEffectsObject.PlayRemoteBap();
		yield return new WaitForSeconds(0.6f);
		SoundEffectsObject.TurnOffRemoteShake();
		SoundEffectsObject.TurnOffRemoteSlide();
		SoundEffectsObject.TurnOffRemoteBap();
		SoundEffectsObject.PlayNSSlam();
		NightStandTopObject.CloseNSTop();
		yield return new WaitForSeconds(1f);
		NightStandTopObject.IdleNStop();
		SoundEffectsObject.TurnOffNSSlam();
		SoundEffectsObject.TurnOffNSOpen();
		//end pre room goes crazy event

		//prelamp crackling
		yield return new WaitForSeconds(1f);
		SoundEffectsObject.PlayLampCrackle();
		LampObject.FlickerLamp();
		yield return new WaitForSeconds(0.9f);
		SoundEffectsObject.TurnOffLampCrackle();
		LampObject.NormalLamp();
		yield return new WaitForSeconds(0.4f);
		SoundEffectsObject.PlayLampCrackle();
		LampObject.FlickerLamp();
		yield return new WaitForSeconds(0.7f);
		SoundEffectsObject.TurnOffLampCrackle();
		LampObject.NormalLamp();
		yield return new WaitForSeconds(0.3f);
		SoundEffectsObject.PlayLampCrackle();
		LampObject.FlickerLamp();
		yield return new WaitForSeconds(0.5f);
		SoundEffectsObject.PlayLightsOnSnap();
		SoundEffectsObject.TurnOffLampCrackle();
		LampObject.NormalLamp();
		LampObject.TurnOffLamp();

		//end pre lamp crackling


		//Room goes crazy and Monster appears at bed
		//Pre room build
		yield return new WaitForSeconds(1f);
		RubixCubeObject.ShakeRubixCube();
		WaterGlassObject.ShakeWaterGlass();
		LaundryBasketObject.ShakeLaundryBasket();
		ClockHandsObject.SpinClockHands();
		TissueBoxObject.ShakeTissueBox();
		WhiteBoardObject.ShakeWhiteBoard();
		FishBowlObject.ShakeFishBowl();
		Trophy1Object.TrophyShakeConstant();
		Trophy6Object.TrophyShakeConstant();
		Trophy7Object.TrophyShakeConstant();
		Picture1Object.PictureSwing();
		ClosetDoorObject.OpenCloseCloset();
		DresserTopObject.OpenCloseTop();
		DeskBotObject.OpenCloseDeskBot();
		DresserMidObject.OpenCloseMid();
		CeilingFanObject.FanOn();
		CeilingFanObject.FastFanSpeed();
		OsFanObject.OSfanOnFast();
		Picture2Object.PictureSwing();
		NightStandTopObject.OpenCloseNStop();
		DeskTopObject.OpenCloseDeskTop();
		DresserBotObject.OpenCloseBot();
		yield return new WaitForSeconds(1f);
		//end pre room build

		//tv and lamp come on and flicker
		SoundEffectsObject.WindVolumeUp(0.01f);
		SoundEffectsObject.TurnOffLightsOnSnap();
		SoundEffectsObject.PlayTvOn();
		SoundEffectsObject.PlayEMBConstant();
		TVObject.TurnOnEmergencyNormal();
		SoundEffectsObject.PlayRattleSoundLong();
		//SoundEffectsObject.PLayClutterNoise ();
		SoundEffectsObject.PlayLampCrackle();
		SoundEffectsObject.PlayClosetDoorCloseOpen();
		LampObject.FlickerLamp();
		SoundEffectsObject.PlayClosetWhispers(0.6f);
		SoundEffectsObject.PlayTvWhispers(0.6f);
		ClosetLightObject.FlickerClosetLight();
		//let player look around at room going crazy
		yield return new WaitForSeconds(5f);
		SoundEffectsObject.TurnOffTvOn();
		yield return new WaitForSeconds(3f);
		SoundEffectsObject.PlayRandomItemsBonkLeft();
		while (pileNumber < 6)
		{
			PileOfThingsObjects[pileNumber].ExplodeObjects();
			pileNumber++;
		}
		yield return new WaitForSeconds(2f);
		SoundEffectsObject.PlayRandomItemsBonkRight();
		while (pileNumber < 12)
		{
			PileOfThingsObjects[pileNumber].ExplodeObjects();
			pileNumber++;
		}
		yield return new WaitForSeconds(1.2f);
		SoundEffectsObject.TurnOffRandomItemsBonkLeft();
		SoundEffectsObject.TurnOffRandomItemsBonkRight();
		//end player time to look around room

		//start bed crawl monster
		BedFootCrawlMonster.SetActive(true);
		yield return new WaitForSeconds(0.8f);
		SoundEffectsObject.PlayThunderSnapSmall();
		LightningLightObject.LightingOn();
		yield return new WaitForSeconds(0.2f);
		LightningLightObject.LightingOff();
		LampObject.NormalLamp();
		LampObject.TurnOffLamp();
		ClosetLightObject.TurnOffClosetLight();
		ClosetLightObject.NormalClosetLight();
		TVObject.TurnOffTV();
		//end bed crawl monster
		//start bed foot monster
		BedFootCrawlMonster.SetActive(false);
		BedFootMonsterObject.TurnMonsterOn();
		yield return new WaitForSeconds(0.5f);
		//MonsterAppears
		ClosetLightObject.FlickerClosetLight();
		ClosetLightObject.TurnOnClosetLight();
		LampObject.TurnOnLampHalf();
		LampObject.FlickerLamp();
		TVObject.TurnOnEmergencyNormal();
		yield return new WaitForSeconds(3f);
		SoundEffectsObject.TurnOffThunderSnapSmall();
		SoundEffectsObject.PlayThunderSnapSmall();
		LightningLightObject.LightingOn();
		yield return new WaitForSeconds(0.2f);
		LightningLightObject.LightingOff();
		LampObject.NormalLamp();
		LampObject.TurnOffLamp();
		ClosetLightObject.TurnOffClosetLight();
		ClosetLightObject.NormalClosetLight();
		TVObject.TurnOffTV();
		BedFootMonsterObject.TurnMonsterOff();
		//end bed foot monster
		//start on bed mosnter
		SoundEffectsObject.PlayMonsterBedWhispers();
		BedMonster.GetComponent<MonsterAppearScript>().TurnMonsterOn();
		BedMonster.GetComponent<BedMonsterScript>().BedMonsterHeadShake();
		yield return new WaitForSeconds(0.5f);
		ClosetLightObject.FlickerClosetLight();
		ClosetLightObject.TurnOnClosetLight();
		LampObject.TurnOnLampHalf();
		LampObject.FlickerLamp();
		TVObject.TurnOnEmergencyNormal();
		SoundEffectsObject.WindVolumeDown(0f);
		yield return new WaitForSeconds(1.5f);
		//Monster Disappears
		//chill out room
		BedMonster.GetComponent<MonsterAppearScript>().TurnMonsterOff();
		SoundEffectsObject.TurnOffMonsterBedWhispers();
		SoundEffectsObject.PlayLightsOnSnap();
		SoundEffectsObject.TurnOffRattleSoundLong();
		SoundEffectsObject.TurnOffEMBConstant();
		SoundEffectsObject.PlayTvOff();
		SoundEffectsObject.TurnOffLampCrackle();
		SoundEffectsObject.TurnOffClosetWhispers();
		SoundEffectsObject.TurnOffTvWhispers();
		SoundEffectsObject.TurnOffClosetDoorCloseOpen();
		TVObject.TurnOffTV();
		RubixCubeObject.IdleRubixCube();
		WaterGlassObject.IdleWaterGlass();
		LaundryBasketObject.IdleLaundryBasket();
		ClockHandsObject.IdleClockHands();
		TissueBoxObject.IdleTissueBox();
		WhiteBoardObject.IdleWhiteBoard();
		FishBowlObject.IdleFishBowl();
		ClosetLightObject.TurnOffClosetLight();
		ClosetLightObject.NormalClosetLight();
		LampObject.TurnOffLamp();
		LampObject.NormalLamp();
		Trophy1Object.TrophyIdle();
		Trophy6Object.TrophyIdle();
		Trophy7Object.TrophyIdle();
		ClosetDoorObject.CloseCloset();
		DresserTopObject.IdleTop();
		DresserBotObject.IdleBot();
		DresserMidObject.IdleMid();
		NightStandTopObject.IdleNStop();
		DeskBotObject.IdleDeskBot();
		DeskTopObject.IdleDeskTop();
		CeilingFanObject.IdleFan();
		OsFanObject.IdleOSfan();
		Picture1Object.PictureIdle();
		Picture2Object.PictureIdle();
		yield return new WaitForSeconds(1f);
		SoundEffectsObject.TurnOffLightsOnSnap();
		SoundEffectsObject.TurnOffTvOff();
		ClosetDoorObject.IdleCloset();
		yield return new WaitForSeconds(6f);

		//end room goes crazy and monster appears at bed

		//Emergency Broadcast death
		yield return new WaitForSeconds (2f);
		SoundEffectsObject.PlayTvOn ();
		TVObject.TurnOnEmergencyEnd ();
		SoundEffectsObject.PlayEMBStart ();
		yield return new WaitForSeconds (13f);
		SoundEffectsObject.TurnOffEMBStart ();
		SoundEffectsObject.TurnOffTvOn ();
		SoundEffectsObject.PlayEMBDeathMessage ();
		yield return new WaitForSeconds (9.5f);
		SoundEffectsObject.TurnOffEMBDeathMessage ();
//		SoundEffectsObject.PlayEMBEnd ();
//		yield return new WaitForSeconds (3f);
//		SoundEffectsObject.TurnOffEMBEnd ();
		SoundEffectsObject.PlayTvOff ();
		TVObject.TurnOffTV ();
		yield return new WaitForSeconds (1f);
		BedsideMonster.GetComponent<MonsterAppearScript> ().TurnMonsterOn ();
		BedsideMonster.GetComponent<BedsideMonsterScript> ().AllowMonsterPop ();
		BedsideMonsterTrigger.SetActive (true);
		CeilingFanObject.FanOn ();
		CeilingFanObject.NormalFanSpeed ();
		OsFanObject.OSfanOn ();
		SoundEffectsObject.PlayLightsOnSnap ();
		LampObject.TurnOnLamp ();
		SoundEffectsObject.TurnOffThunderSnapSmall ();
		yield return new WaitForSeconds (1f);
		SoundEffectsObject.TurnOffLightsOnSnap ();
		SoundEffectsObject.TurnOffTvOff ();
		yield return new WaitForSeconds (2f);
		SoundEffectsObject.PlayDoorCreak ();
		BedroomDoorObject.OpenBedRoomDoor ();

		//end shuffling to side of bed and monster leap

		//Debug.Log ("GAME OVER");
	}
}