using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectManagerScript : MonoBehaviour {

	public GameObject ThunderSnap;
	public GameObject ThunderSnapSmall;
	public GameObject EmergencyBroadcastStart;
	public GameObject EmergencyBroadcastEnd;
	public GameObject EmergencyBroadcastMessageTest;
	public GameObject EmergencyBroadcastDeathMessage;
	public GameObject EmergnecyBroadcastConstant;
	public GameObject TvOn;
	public GameObject TvOff;
	public GameObject ClosetLightOn;
	public GameObject ClosetLightOff;
	public GameObject ClosetDoorOpen;
	public GameObject ClosetDoorClose;
	public GameObject ClosetDoorCloseOpen;
	public GameObject ClosetThud;
	public GameObject FootStep1;
	public GameObject FootStep2;
	public GameObject FootStep3;
	public GameObject FootStep4;
	public GameObject LightsOnSnap;
	public GameObject ClockTick;
	public GameObject LampCrackle;
	public GameObject RattleSound;
	public GameObject RattleSoundLong;
	public GameObject ChairSqueakBack;
	public GameObject ChairSqueakForward;
	public GameObject ChairTwistSqueak;
	public GameObject ClosetWhispers;
	public GameObject TvWhispers;
	public GameObject TrophyBonk;
	public GameObject TrophyBap;
	public GameObject GlassBreak;
	public GameObject PictureThrow;
	public GameObject NSSlam;
	public GameObject NSOpen;
	public GameObject RemoteShake;
	public GameObject RemoteSlide;
	public GameObject RemoteBap;
	public GameObject BookBonk;
	public GameObject BookSlide;
	public GameObject RandomItemsBonkLeft;
	public GameObject RandomItemsBonkRight;
	public GameObject DoorCreak;
	public GameObject MonsterBedWhispers;
	public GameObject RandomRightSideBump;
	public GameObject RandomLeftSideBump;
	public GameObject ClutterNoise;
	public GameObject BookBonk2;
	public GameObject TrophieBap2;
	public GameObject Wind;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PlayThunderSnap(){
		ThunderSnap.SetActive (true);
	}

	public void TurnOffThunderSnap(){
		ThunderSnap.SetActive (false);
	}

	public void PlayEMBStart(){
		EmergencyBroadcastStart.SetActive (true);
	}

	public void TurnOffEMBStart(){
		EmergencyBroadcastStart.SetActive (false);
	}

	public void PlayEMBEnd(){
		EmergencyBroadcastEnd.SetActive (true);
	}

	public void TurnOffEMBEnd(){
		EmergencyBroadcastEnd.SetActive (false);
	}

	public void PlayEMBMessageTest(){
		EmergencyBroadcastMessageTest.SetActive (true);
	}

	public void TurnOffEMBMessageTest(){
		EmergencyBroadcastMessageTest.SetActive (false);
	}

	public void PlayEMBConstant(){
		EmergnecyBroadcastConstant.SetActive (true);
	}

	public void TurnOffEMBConstant(){
		EmergnecyBroadcastConstant.SetActive (false);
	}

	public void PlayEMBDeathMessage(){
		EmergencyBroadcastDeathMessage.SetActive (true);
	}

	public void TurnOffEMBDeathMessage(){
		EmergencyBroadcastDeathMessage.SetActive (false);
	}

	public void PlayTvOn(){
		TvOn.SetActive (true);
	}

	public void TurnOffTvOn(){
		TvOn.SetActive (false);
	}

	public void PlayTvOff(){
		TvOff.SetActive (true);
	}

	public void TurnOffTvOff(){
		TvOff.SetActive (false);
	}

	public void PlayClosetLightOn(){
		ClosetLightOn.SetActive (true);
	}

	public void TurnOffClosetLightOn(){
		ClosetLightOn.SetActive (false);
	}

	public void PlayClosetLightOff(){
		ClosetLightOff.SetActive (true);
	}

	public void TurnOffClosetLightOff(){
		ClosetLightOff.SetActive (false);
	}

	public void PlayClosetDoorOpen(){
		ClosetDoorOpen.SetActive (true);
	}

	public void TurnOffClosetDoorOpen(){
		ClosetDoorOpen.SetActive (false);
	}

	public void PlayClosetDoorClose(){
		ClosetDoorClose.SetActive (true);
	}

	public void TurnOffClosetDoorClose(){
		ClosetDoorClose.SetActive (false);
	}

	public void PlayClosetDoorCloseOpen(){
		ClosetDoorCloseOpen.SetActive (true);
	}

	public void TurnOffClosetDoorCloseOpen(){
		ClosetDoorCloseOpen.SetActive (false);
	}

	public void PlayClosetThud(){
		ClosetThud.SetActive (true);
	}

	public void TurnOffClosetThud(){
		ClosetThud.SetActive (false);
	}

	public void PlayFootStep1(){
		FootStep1.SetActive (true);
	}

	public void TurnOffFootStep1(){
		FootStep1.SetActive (false);
	}

	public void PlayFootStep2(){
		FootStep2.SetActive (true);
	}

	public void TurnOffFootStep2(){
		FootStep2.SetActive (false);
	}

	public void PlayFootStep3(){
		FootStep3.SetActive (true);
	}

	public void TurnOffFootStep3(){
		FootStep3.SetActive (false);
	}

	public void PlayFootStep4(){
		FootStep4.SetActive (true);
	}

	public void TurnOffFootStep4(){
		FootStep4.SetActive (false);
	}

	public void PlayLightsOnSnap(){
		LightsOnSnap.SetActive (true);
	}

	public void TurnOffLightsOnSnap(){
		LightsOnSnap.SetActive (false);
	}

	public void PlayClockTick(){
		ClockTick.SetActive (true);
	}

	public void TurnOffClockTick(){
		ClockTick.SetActive (false);
	}

	public void PlayLampCrackle(){
		LampCrackle.SetActive (true);
	}

	public void TurnOffLampCrackle(){
		LampCrackle.SetActive (false);
	}

	public void PlayRattleSound(){
		RattleSound.SetActive (true);
	}

	public void TurnOffRattleSound(){
		RattleSound.SetActive (false);
	}

	public void PlayRattleSoundLong(){
		RattleSoundLong.SetActive (true);
	}

	public void TurnOffRattleSoundLong(){
		RattleSoundLong.SetActive (false);
	}

	public void PlayChairSqueakBack(){
		ChairSqueakBack.SetActive (true);
	}

	public void TurnOffChairSqueakBack(){
		ChairSqueakBack.SetActive (false);
	}

	public void PlayChairSqueakForward(){
		ChairSqueakForward.SetActive (true);
	}

	public void TurnOffChairSqueakForward(){
		ChairSqueakForward.SetActive (false);
	}

	public void PlayChairTwistSqueak(){
		ChairTwistSqueak.SetActive (true);
	}

	public void TurnOffChairTwistSqeuak(){
		ChairTwistSqueak.SetActive (false);
	}

	public void PlayClosetWhispers(float volume){
		//ClosetWhispers.GetComponent<GvrAudioSource> ().volume = volume;
		ClosetWhispers.SetActive (true);
	}

	public void TurnOffClosetWhispers(){
		ClosetWhispers.SetActive (false);
	}

	public void PlayTvWhispers(float volume){
		//TvWhispers.GetComponent<GvrAudioSource> ().volume = volume;
		TvWhispers.SetActive (true);
	}

	public void TurnOffTvWhispers(){
		TvWhispers.SetActive (false);
	}

	public void PlayTrophyBonk(){
		TrophyBonk.SetActive (true);
	}

	public void TurnOffTrophyBonk(){
		TrophyBonk.SetActive (false);
	}

	public void PlayTrophyBap(){
		TrophyBap.SetActive (true);
	}

	public void TurnOffTrophyBap(){
		TrophyBap.SetActive (false);
	}

	public void PlayThunderSnapSmall(){
		ThunderSnapSmall.SetActive (true);
	}

	public void TurnOffThunderSnapSmall(){
		ThunderSnapSmall.SetActive (false);
	}

	public void PlayGlassBreak(){
		GlassBreak.SetActive (true);
	}

	public void TurnOffGlassBreak(){
		GlassBreak.SetActive (false);
	}

	public void PlayPictureThrow(){
		PictureThrow.SetActive (true);
	}

	public void TurnOffPictureThrow(){
		PictureThrow.SetActive (false);
	}

	public void PlayNSOpen(){
		NSOpen.SetActive (true);
	}

	public void TurnOffNSOpen(){
		NSOpen.SetActive (false);
	}

	public void PlayNSSlam(){
		NSSlam.SetActive (true);
	}

	public void TurnOffNSSlam(){
		NSSlam.SetActive (false);
	}

	public void PlayRemoteShake() {
		RemoteShake.SetActive (true);
	}

	public void TurnOffRemoteShake() {
		RemoteShake.SetActive (false);
	}

	public void PlayRemoteSlide(){
		RemoteSlide.SetActive (true);
	}

	public void TurnOffRemoteSlide(){
		RemoteSlide.SetActive (false);
	}

	public void PlayRemoteBap(){
		RemoteBap.SetActive (true);
	}

	public void TurnOffRemoteBap(){
		RemoteBap.SetActive (false);
	}

	public void PlayBookBonk(){
		BookBonk.SetActive (true);
	}

	public void TurnOffBookBonk(){
		BookBonk.SetActive (false);
	}

	public void PlayBookSlide(){
		BookSlide.SetActive (true);
	}

	public void TurnOffBookSlide(){
		BookSlide.SetActive (false);
	}

	public void PlayRandomItemsBonkLeft(){
		RandomItemsBonkLeft.SetActive (true);
	}

	public void TurnOffRandomItemsBonkLeft(){
		RandomItemsBonkLeft.SetActive (false);
	}

	public void PlayRandomItemsBonkRight(){
		RandomItemsBonkRight.SetActive (true);
	}

	public void TurnOffRandomItemsBonkRight(){
		RandomItemsBonkRight.SetActive (false);
	}

	public void PlayDoorCreak(){
		DoorCreak.SetActive (true);
	}

	public void TurnOffDoorCreak(){
		DoorCreak.SetActive (false);
	}

	public void PlayMonsterBedWhispers(){
		MonsterBedWhispers.SetActive (true);
	}

	public void TurnOffMonsterBedWhispers(){
		MonsterBedWhispers.SetActive (false);
	}

	public void PlayRandomRightSideBump(){
		RandomRightSideBump.SetActive (true);
	}

	public void TurnOffRandomRightSideBump(){
		RandomRightSideBump.SetActive (false);
	}

	public void PlayRandomLeftSideBump(){
		RandomLeftSideBump.SetActive (true);
	}

	public void TurnOffRandomLeftSideBump(){
		RandomLeftSideBump.SetActive (false);
	}

	public void PlayClutterNoise(){
		ClutterNoise.SetActive (true);
	}

	public void TurnOffClutterNoise(){
		ClutterNoise.SetActive (false);
	}

	public void PlayBookBonk2(){
		BookBonk2.SetActive (true);
	}

	public void TurnOffBookBonk2(){
		BookBonk2.SetActive (false);
	}

	public void PlayTrophyBap2(){
		TrophieBap2.SetActive (true);
	}

	public void TurnOffTrophyBap2(){
		TrophieBap2.SetActive (false);
	}

	public void PlayWind(){
		Wind.SetActive (true);
	}

	public void TurnOffWind(){
		Wind.SetActive (false);
	}

	public void WindVolumeUp(float volume){
		StartCoroutine (WindVolumeUpCo (volume));
	}

	public void WindVolumeDown(float volume){
		StartCoroutine (WindVolumeDownCo (volume));
	}

	IEnumerator WindVolumeUpCo(float targetVolume){
        //while (Wind.GetComponent<GvrAudioSource> ().volume < targetVolume) {
        //	Wind.GetComponent<GvrAudioSource> ().volume += 0.01f;
        //	yield return new WaitForSeconds (0.1f);
        //}
        yield return null;
	}

	IEnumerator WindVolumeDownCo(float targetVolume){
        //while (Wind.GetComponent<GvrAudioSource> ().volume > targetVolume) {
        //	Wind.GetComponent<GvrAudioSource> ().volume -= 0.01f;
        //	yield return new WaitForSeconds (0.1f);
        //}
        yield return null;
	}
}
