using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SilenceTimeline : MonoBehaviour
{

    [SerializeField]
    private CameraBlackOut blackOut = null;

    [SerializeField]
    private bool runStory = false;

    [SerializeField] private GameObject shadowManDoor = null;
    [SerializeField] private GameObject shadowManRadio = null;
    [SerializeField] private GameObject shadowManDesk = null;
    [SerializeField] private GameObject shadowManNearYou = null;
    [SerializeField] private GameObject shadowManFire = null;
    [SerializeField] private GameObject shadowManFire2 = null;
    [SerializeField] private GameObject shadowManEnd = null;
    [SerializeField] private MonsterFade monsterFade = null;
    [SerializeField] private MonsterBreathing monsterBreathing = null;
    [SerializeField] private MonsterEnd monsterEnding = null;

    [Header("Animation Events")]
    [SerializeField] private Animator desk1Animator = null;
    [SerializeField] private Animator desk2Animator = null;
    [SerializeField] private Animator doorAnimator = null;
    [SerializeField] private Animator pencilRollAnimator = null;
    [SerializeField] private Animator pencilHolderAnimator = null;
    [SerializeField] private Animator playerDeskAnimator = null;
    [SerializeField] private Animator playerPaperAnimator = null;
    [SerializeField] private Animator playerPencilAnimator = null;


    [Space(10)]

    [Header("Physics Events")]
    [SerializeField] private CabinetDoorSmash cabinetDoor = null;
    [SerializeField] private ClockGlass clock = null;
    [SerializeField] private CupSlap pencil1 = null;
    [SerializeField] private CupSlap pen1 = null;
    [SerializeField] private CupSlap pen2 = null;
    [SerializeField] private CupSlap cup = null;
    [SerializeField] private Desk1 desk1 = null;
    [SerializeField] private Desk2 desk2 = null;
    [SerializeField] private Desk3 desk3 = null;
    [SerializeField] private DoorGlass doorGlass = null;
    [SerializeField] private DoorSmash door = null;
    [SerializeField] private FireAlarmSmash fireAlarm = null;
    [SerializeField] private RadioSmash radio = null;
    [SerializeField] private ThrowBook throwBook = null;
    [SerializeField] private ThrowMonitor throwMonitor = null;

    [Space(10)]

    [Header("Sound Events")]
    [SerializeField] private AudioSource roomTone = null;
    [SerializeField] private AudioSource radioAudio = null;
    [SerializeField] private AudioSource clockAudio = null;
    [SerializeField] private AudioSource lightCrackle = null;
    [SerializeField] private AudioSource radioStatic = null;
    [SerializeField] private AudioSource radioOff = null;
    [SerializeField] private AudioSource hallHeavyFootStep1 = null;
    [SerializeField] private AudioSource hallHeavyFootStep2 = null;
    [SerializeField] private AudioSource hallHeavyFootStep3 = null;
    [SerializeField] private AudioSource monsterGroanHall1 = null;
    [SerializeField] private AudioSource electricStatic = null;
    [SerializeField] private AudioSource electricPop = null;
    [SerializeField] private AudioSource generatorTurnOn = null;
    [SerializeField] private AudioSource hallHeavyFootStep4 = null;
    [SerializeField] private AudioSource hallHeavyFootStep5 = null;
    [SerializeField] private AudioSource hallHeavyFootStep6 = null;
    [SerializeField] private AudioSource hallGlassBreak = null;
    [SerializeField] private AudioSource monsterGoranHall2 = null;
    [SerializeField] private AudioSource hallLightFootStep1 = null;
    [SerializeField] private AudioSource hallLightFootStep2 = null;
    [SerializeField] private AudioSource hallLightFootStep3 = null;
    [SerializeField] private AudioSource hallLightFootStep4 = null;
    [SerializeField] private AudioSource hallLightFootStep5 = null;
    [SerializeField] private AudioSource doorOpen = null;
    [SerializeField] private AudioSource doorClose = null;
    [SerializeField] private AudioSource doorLocks = null;
    [SerializeField] private AudioSource doorHandle = null;
    [SerializeField] private AudioSource classLightFootStep1 = null;
    [SerializeField] private AudioSource classLightFootStep2 = null;
    [SerializeField] private AudioSource classLightFootStep3 = null;
    [SerializeField] private AudioSource classLightFootStep4 = null;
    [SerializeField] private AudioSource classLightFootStep5 = null;
    [SerializeField] private AudioSource classLightFootStep6 = null;
    [SerializeField] private AudioSource classLightFootStep7 = null;
    [SerializeField] private AudioSource classLightFootStep8 = null;
    [SerializeField] private AudioSource deskNudge = null;
    [SerializeField] private AudioSource pencilRoll = null;
    [SerializeField] private AudioSource pencilFloorHit = null;
    [SerializeField] private AudioSource embSound = null;
    [SerializeField] private AudioSource embDallas = null;
    [SerializeField] private AudioSource embResidents = null;
    [SerializeField] private AudioSource embInstructions = null;
    [SerializeField] private AudioSource runningBreath = null;
    [SerializeField] private AudioSource breathIn = null;
    [SerializeField] private AudioSource breathOut = null;
    [SerializeField] private AudioSource dontLetItHearYou = null;
    [SerializeField] private AudioSource hallHeavyFootStep7 = null;
    [SerializeField] private AudioSource hallHeavyFootStep8 = null;
    [SerializeField] private AudioSource hallHeavyFootStep9 = null;
    [SerializeField] private AudioSource monsterGroanHall3 = null;
    [SerializeField] private AudioSource hallHeavyFootStep10 = null;
    [SerializeField] private AudioSource hallHeavyFootStep11= null;
    [SerializeField] private AudioSource hallHeavyFootStep12 = null;
    [SerializeField] private AudioSource doorMonsterGroan = null;
    [SerializeField] private AudioSource doorGlassBreak = null;
    [SerializeField] private AudioSource doorSlam = null;
    [SerializeField] private AudioSource doorBreak = null;
    [SerializeField] private AudioSource hallHeavyFootStep13 = null;
    [SerializeField] private AudioSource hallHeavyFootStep14 = null;
    [SerializeField] private AudioSource hallHeavyFootStep15 = null;
    [SerializeField] private AudioSource roomGlassStep1 = null;
    [SerializeField] private AudioSource roomGlassStep2 = null;
    [SerializeField] private AudioSource roomHeavyFootStep1 = null;
    [SerializeField] private AudioSource roomHeavyFootStep2 = null;
    [SerializeField] private AudioSource smashRadio = null;
    [SerializeField] private AudioSource doorLand = null;
    [SerializeField] private AudioSource roomMonsterGroan1 = null;
    [SerializeField] private AudioSource roomHeavyFootStep3 = null;
    [SerializeField] private AudioSource roomHeavyFootStep4 = null;
    [SerializeField] private AudioSource roomGlassStep3 = null;
    [SerializeField] private AudioSource clockBreak = null;
    [SerializeField] private AudioSource roomMonsterGroan2 = null;
    [SerializeField] private AudioSource desk1Lift = null;
    [SerializeField] private AudioSource desk1Shake = null;
    [SerializeField] private AudioSource desk1Drop = null;
    [SerializeField] private AudioSource roomMonsterFootStep5 = null;
    [SerializeField] private AudioSource roomMonsterFootStep6 = null;
    [SerializeField] private AudioSource desk2Lift = null;
    [SerializeField] private AudioSource desk2Shake = null;
    [SerializeField] private AudioSource desk2Drop = null;
    [SerializeField] private AudioSource roomMonsterFootStep7 = null;
    [SerializeField] private AudioSource roomMonsterFootStep8 = null;
    [SerializeField] private AudioSource bookSmack = null;
    [SerializeField] private AudioSource bookCollide = null;
    [SerializeField] private AudioSource bookLand = null;
    [SerializeField] private AudioSource roomMonsterGroan3 = null;
    [SerializeField] private AudioSource roomMonsterFootStep9 = null;
    [SerializeField] private AudioSource roomMonsterFootStep10 = null;
    [SerializeField] private AudioSource roomMonsterGrunt = null;
    [SerializeField] private AudioSource roomDesk1Hit = null;
    [SerializeField] private AudioSource roomDesk2Hit = null;
    [SerializeField] private AudioSource roomMonsterFootStep11 = null;
    [SerializeField] private AudioSource roomMonsterFootStep12 = null;
    [SerializeField] private AudioSource roomDesk3Hit = null;
    [SerializeField] private AudioSource roomMonsterGrunt2 = null;
    [SerializeField] private AudioSource roomMonsterGroan4 = null;
    [SerializeField] private AudioSource fireAlarmSound = null;
    [SerializeField] private AudioSource roomMonsterGroan5 = null;
    [SerializeField] private AudioSource roomMonsterFootStep13 = null;
    [SerializeField] private AudioSource roomMonsterFootStep14 = null;
    [SerializeField] private AudioSource roomMonsterFootStep15= null;
    [SerializeField] private AudioSource roomMonsterFootStep16 = null;
    [SerializeField] private AudioSource roomMonsterFootStep17 = null;
    [SerializeField] private AudioSource roomMonsterGrunt3 = null;
    [SerializeField] private AudioSource roomMonsterGrunt4 = null;
    [SerializeField] private AudioSource roomMonsterGrunt5 = null;
    [SerializeField] private AudioSource cabinetBreakSound = null;
    [SerializeField] private AudioSource monitorSmackSound = null;
    [SerializeField] private AudioSource monitorLandSound = null;
    [SerializeField] private AudioSource fireAlarmHitSound = null;
    [SerializeField] private AudioSource roomMonsterGroan6 = null;
    [SerializeField] private AudioSource gettingOutOfHere = null;
    [SerializeField] private AudioSource roomLeavingFootStep3 = null;
    [SerializeField] private AudioSource roomLeavingFootStep4 = null;
    [SerializeField] private AudioSource roomMonsterGroan7 = null;
    [SerializeField] private AudioSource imSorry = null;
    [SerializeField] private AudioSource cupSlide = null;
    [SerializeField] private AudioSource cupSlapSound = null;
    [SerializeField] private AudioSource groundClutternoise = null;
    [SerializeField] private AudioSource roomMonsterRoar = null;
    [SerializeField] private AudioSource roomMonsterGrunt6 = null;
    [SerializeField] private AudioSource roomMonsterGrunt7 = null;
    [SerializeField] private AudioSource chairClatter1 = null;
    [SerializeField] private AudioSource chairClatter2 = null;
    [SerializeField] private AudioSource roomMonsterFootStep18 = null;
    [SerializeField] private AudioSource roomMonsterLiftGrunt = null;
    [SerializeField] private AudioSource roomMonsterLowGrowl = null;
    [SerializeField] private AudioSource roomMonsterFinalSound = null;
    [SerializeField] private AudioSource roomMonsterGrunt8 = null;
    [SerializeField] private AudioSource roomMonsterGrunt9 = null;
    [SerializeField] private AudioSource monsterBreath = null;
    [SerializeField] private AudioSource radioBroadcast = null;
    [SerializeField] private AudioSource radioMonsterScream = null;
    [SerializeField] private AudioSource desk1Throw = null;
    [SerializeField] private AudioSource desk2Throw = null;
    [SerializeField] private AudioSource radioOn = null;
    [SerializeField] private AudioSource alarmGlassBreak = null;

    [Space(10)]

    [Header("Lighting Events")]
    [SerializeField] private Lighting classroomLights = null;
    [SerializeField] private Lighting fireAlarmLight = null;

    [Space(10)]

    [Header("MISC")]
    [SerializeField] private RadioPitchChange radioPitch = null;
    [SerializeField] private ClockSecondHand clockSecondHand = null;

    private float experienceLength = 0f;

    [SerializeField] private bool showFigure = false;

    private void Start()
    {
        blackOut.FadeOutBlocker();

        if (runStory)
        {
            StartCoroutine(RunStory());
        }

    }

    private void Update()
    {
        experienceLength += Time.deltaTime;
    }

    private IEnumerator RunStory()
    {

        classroomLights.SetLightRange(55f, 1f);
        roomTone.Play();
        clockAudio.Play();
        radioAudio.Play();
        radioPitch.TurnOnRadioLight();

        //give the player time to look around
        yield return new WaitForSeconds(12f);

        //1st radio pitch change
        radioStatic.Play();
        radioPitch.ChangePitch(0.35f, 5f);
        yield return new WaitForSeconds(0.3f);
        radioPitch.ChangePitch(1f, 5f);
        radioStatic.Stop();

        yield return new WaitForSeconds(3f);

        //2nd radio pitch change
        lightCrackle.Play();
        classroomLights.StartLightFlicker();
        radioStatic.Play();
        radioPitch.ChangePitch(0.4f, 5f);
        yield return new WaitForSeconds(0.35f);
        radioPitch.ChangePitch(1f, 5f);
        radioStatic.Stop();
        classroomLights.StopLightFlicker();
        lightCrackle.Stop();

        yield return new WaitForSeconds(4f);

        //radio pitch change, reverse, and stop
        lightCrackle.Play();
        classroomLights.StartLightFlicker();
        radioStatic.Play();
        radioPitch.ChangePitch(0.4f, 5f);
        yield return new WaitForSeconds(0.25f);
        radioPitch.ChangePitch(0.7f, 5f);
        yield return new WaitForSeconds(0.25f);
        classroomLights.StopLightFlicker();
        lightCrackle.Stop();
        radioPitch.ChangePitch(0.2f, 5f);
        yield return new WaitForSeconds(0.25f);
        radioPitch.ChangePitch(0.6f, 5f);
        yield return new WaitForSeconds(0.25f);
        lightCrackle.Play();
        classroomLights.StartLightFlicker();
        radioPitch.ChangePitch(-1f, 1f);
        radioPitch.ChangeVolume(1f, 1f);
        radioPitch.ChangeSpecialBlend(0, 1f);
        yield return new WaitForSeconds(1f);
        classroomLights.StopLightFlicker();
        lightCrackle.Stop();
        yield return new WaitForSeconds(5f);
        radioPitch.ChangePitch(1f, 5f);
        radioPitch.ChangeVolume(0.25f, 1f);
        radioPitch.ChangeSpecialBlend(0.75f, 1f);
        radioStatic.Stop();
        radioAudio.Stop();
        radioPitch.TurnOffRadioLight();
        radioOff.Play();

        yield return new WaitForSeconds(2f);

        //light flicker
        lightCrackle.Play();
        classroomLights.StartLightFlicker();
        yield return new WaitForSeconds(1f);
        classroomLights.StopLightFlicker();
        lightCrackle.Stop();

        yield return new WaitForSeconds(1f);

        //light flicker
        lightCrackle.Play();
        classroomLights.StartLightFlicker();
        yield return new WaitForSeconds(1f);
        classroomLights.StopLightFlicker();
        lightCrackle.Stop();

        yield return new WaitForSeconds(1f);

        //hall heavy footsteps
        hallHeavyFootStep1.Play();
        yield return new WaitForSeconds(2f);
        hallHeavyFootStep2.Play();
        yield return new WaitForSeconds(1.8f);
        hallHeavyFootStep3.Play();
        yield return new WaitForSeconds(1f);

        //hall groan
        lightCrackle.Play();
        classroomLights.StartLightFlicker();
        monsterGroanHall1.Play();
        yield return new WaitForSeconds(3.7f);
        classroomLights.StopLightFlicker();
        lightCrackle.Stop();
        yield return new WaitForSeconds(2f);

        //radio restart
        radioStatic.Play();
        radioAudio.Play();
        radioOn.Play();
        radioPitch.TurnOnRadioLight();
        radioPitch.ChangePitch(0.35f, 5f);
        yield return new WaitForSeconds(0.3f);
        radioPitch.ChangePitch(1f, 5f);
        radioStatic.Stop();

        yield return new WaitForSeconds(8f);

        //radio pitch change
        radioStatic.Play();
        radioPitch.ChangePitch(0.35f, 5f);
        yield return new WaitForSeconds(0.3f);
        radioPitch.ChangePitch(1f, 5f);
        radioStatic.Stop();

        yield return new WaitForSeconds(3f);

        //radio pitch change
        radioStatic.Play();
        radioPitch.ChangePitch(0.5f, 5f);
        yield return new WaitForSeconds(0.3f);
        radioPitch.ChangePitch(1f, 5f);
        radioStatic.Stop();

        yield return new WaitForSeconds(3.5f);

        //radio pitch change to electric pop power outage
        radioStatic.Play();
        radioPitch.ChangePitch(-1f, 1f);
        radioPitch.ChangeVolume(1f, 1f);
        radioPitch.ChangeSpecialBlend(0f, 1f);
        yield return new WaitForSeconds(3f);
        electricStatic.Play();
        yield return new WaitForSeconds(0.25f);
        electricPop.Play(); //REPLACE WITH MUCH LOUNDER POP SOUND
        radioAudio.Stop();
        radioOff.Play();
        radioPitch.ChangePitch(1f, 5f);
        radioPitch.ChangeVolume(0.25f, 1f);
        radioPitch.ChangeSpecialBlend(0.75f, 1f);
        radioPitch.SetRadioLightIntensity(13f);
        classroomLights.TurnOffLights();

        //lights fade back in to dim
        yield return new WaitForSeconds(4f);
        classroomLights.TurnOnLights(0f);
        classroomLights.SetLightRange(8f, 4f);
        yield return new WaitForSeconds(1f);
        generatorTurnOn.Play();
        yield return new WaitForSeconds(6f);

        //Emergency Broadcast here
        embSound.Play();
        yield return new WaitForSeconds(12.6f);
        embDallas.Play();
        yield return new WaitForSeconds(3.9f);
        embResidents.Play();
        yield return new WaitForSeconds(3f);
        //embInstructions.Play();
        //yield return new WaitForSeconds(3f);
        embResidents.Stop();
        radioMonsterScream.Play();
        yield return new WaitForSeconds(4.4f);
        radioBroadcast.Play();
        yield return new WaitForSeconds(21f);
        radioPitch.TurnOffRadioLight();
        radioOff.Play();

        //pause all sound except clock and room tone
        radioStatic.Stop();

        yield return new WaitForSeconds(4f);

        //light flicker
        lightCrackle.Play();
        classroomLights.StartLightFlicker();
        yield return new WaitForSeconds(1f);
        classroomLights.StopLightFlicker();
        lightCrackle.Stop();

        yield return new WaitForSeconds(2f);

        //hall heavy footsteps and glass break;
        hallHeavyFootStep4.Play();
        yield return new WaitForSeconds(2f);
        hallHeavyFootStep5.Play();
        yield return new WaitForSeconds(1.8f);
        hallHeavyFootStep6.Play();
        yield return new WaitForSeconds(1f);
        hallGlassBreak.Play();
        yield return new WaitForSeconds(0.25f);
        monsterGoranHall2.Play();

        yield return new WaitForSeconds(2.5f);

        //hall light footsteps
        hallLightFootStep1.Play();
        yield return new WaitForSeconds(0.3f);
        hallLightFootStep2.Play();
        yield return new WaitForSeconds(0.335f);
        hallLightFootStep3.Play();
        yield return new WaitForSeconds(0.4f);
        hallLightFootStep4.Play();
        yield return new WaitForSeconds(0.35f);
        hallLightFootStep5.Play();

        yield return new WaitForSeconds(1f);

        //open door
        doorAnimator.SetTrigger("Event2");
        doorHandle.Play();
        lightCrackle.Play();
        yield return new WaitForSeconds(0.25f);
        classroomLights.StartLightFlicker();
        yield return new WaitForSeconds(0.25f);
        classroomLights.StopLightFlicker();
        yield return new WaitForSeconds(0.25f);
        classroomLights.StartLightFlicker();
        yield return new WaitForSeconds(0.25f);
        classroomLights.StopLightFlicker();
        lightCrackle.Stop();
        doorOpen.Play();

        yield return new WaitForSeconds(2.5f);
        doorClose.Play();
        yield return new WaitForSeconds(0.7f);
        doorHandle.Play();
        yield return new WaitForSeconds(0.8f);
        doorLocks.Play();

        yield return new WaitForSeconds(0.35f);

        //light foot steps in class room
        classLightFootStep1.Play();
        yield return new WaitForSeconds(0.3f);
        classLightFootStep2.Play();
        yield return new WaitForSeconds(0.335f);
        classLightFootStep3.Play();
        yield return new WaitForSeconds(0.4f);
        classLightFootStep4.Play();
        yield return new WaitForSeconds(0.35f);
        classLightFootStep5.Play();
        yield return new WaitForSeconds(0.15f);
        //desk Nudge
        desk2Animator.SetTrigger("Event4");
        deskNudge.Play();
        yield return new WaitForSeconds(0.05f);
        pencilRollAnimator.SetTrigger("Event2");
        pencilRoll.Play();
        yield return new WaitForSeconds(0.2f);
        classLightFootStep6.Play();
        yield return new WaitForSeconds(0.35f);
        classLightFootStep7.Play();
        yield return new WaitForSeconds(0.15f);
        runningBreath.Play();
        yield return new WaitForSeconds(0.15f);
        classLightFootStep8.Play();
        yield return new WaitForSeconds(0.5f);
        breathIn.Play();
        yield return new WaitForSeconds(0.5f);
        breathOut.Play();
        pencilFloorHit.Play();

        yield return new WaitForSeconds(4f);

        //heavy steps to door and dont let it hear you
        hallHeavyFootStep7.Play();
        yield return new WaitForSeconds(2f);
        hallHeavyFootStep8.Play();
        yield return new WaitForSeconds(1.8f);
        hallHeavyFootStep9.Play();
        yield return new WaitForSeconds(2f);
        dontLetItHearYou.Play();

        yield return new WaitForSeconds(4f);
        monsterGroanHall3.Play();

        yield return new WaitForSeconds(6f);

        //monster walk away
        hallHeavyFootStep10.Play();
        yield return new WaitForSeconds(2f);
        hallHeavyFootStep11.Play();
        yield return new WaitForSeconds(1.8f);
        hallHeavyFootStep12.Play();
        yield return new WaitForSeconds(2f);

        // radio turns back on
        radioPitch.ChangePitch(-1f, 5f);
        radioPitch.ChangeVolume(1f, 5f);
        radioPitch.ChangeSpecialBlend(0, 1f);
        radioAudio.Play();
        radioOn.Play();
        radioPitch.TurnOnRadioLight();
        radioStatic.Play();
        yield return new WaitForSeconds(1f);
        lightCrackle.Play();
        classroomLights.StartLightFlicker();
        yield return new WaitForSeconds(2f);
        classroomLights.StopLightFlicker();
        lightCrackle.Stop();
        yield return new WaitForSeconds(1.25f);
        radioPitch.ChangePitch(2f, 1f);
        radioPitch.ChangeVolume(1f, 5f);
        radioPitch.ChangeSpecialBlend(0, 1f);
        yield return new WaitForSeconds(1f);
        radioPitch.ChangePitch(1f, 5f);
        radioPitch.ChangeVolume(0.25f, 5f);
        radioPitch.ChangeSpecialBlend(0.75f, 5f);
        radioAudio.Stop();
        radioPitch.TurnOffRadioLight();
        radioStatic.Stop();
        radioOff.Play();

        yield return new WaitForSeconds(6f);

        //door glass break
        doorGlassBreak.Play();
        doorGlass.BreakGlass();
        doorMonsterGroan.Play();

        yield return new WaitForSeconds(1f);
        radioPitch.ChangePitch(-1f, 5f);
        radioPitch.ChangeVolume(1f, 5f);
        radioPitch.ChangeSpecialBlend(0, 1f);
        radioAudio.Play();
        radioOn.Play();
        radioPitch.TurnOnRadioLight();
        radioStatic.Play();
        lightCrackle.Play();
        classroomLights.StartLightFlicker();
        yield return new WaitForSeconds(1f);
        doorAnimator.SetTrigger("Event4");
        doorSlam.Play();
        yield return new WaitForSeconds(1.5f);
        doorAnimator.SetTrigger("Event4");
        doorSlam.Play();
        yield return new WaitForSeconds(0.25f);
        classroomLights.StopLightFlicker();
        lightCrackle.Stop();

        yield return new WaitForSeconds(2.5f);

        //run up to break door
        hallHeavyFootStep13.Play();
        yield return new WaitForSeconds(0.3f);
        hallHeavyFootStep14.Play();
        yield return new WaitForSeconds(0.35f);
        hallHeavyFootStep15.Play();
        yield return new WaitForSeconds(0.2f);
        door.BreakDoor();

        if (showFigure)
        {
            shadowManDoor.SetActive(true);
        }
        monsterFade.SetAlphaTarget(15 / 255f, 0.15f);
        classroomLights.StartLightFlicker();
        lightCrackle.Play();
        doorBreak.Play();

        yield return new WaitForSeconds(.4f);
        doorLand.Play();

        yield return new WaitForSeconds(2f);
        classroomLights.StopLightFlicker();
        lightCrackle.Stop();
        monsterFade.SetAlphaTarget(0f, 0.25f);
        monsterBreath.Play();

        //walk up to break radio
        roomGlassStep1.Play();
        monsterBreathing.SetTargetTransform(roomGlassStep1.transform, 3f);
        yield return new WaitForSeconds(0.65f);
        roomGlassStep2.Play();
        monsterBreathing.SetTargetTransform(roomGlassStep2.transform, 3f);
        yield return new WaitForSeconds(0.65f);
        roomHeavyFootStep1.Play();
        monsterBreathing.SetTargetTransform(roomHeavyFootStep1.transform, 3f);
        yield return new WaitForSeconds(0.55f);
        roomHeavyFootStep2.Play();
        monsterBreathing.SetTargetTransform(roomHeavyFootStep2.transform, 3f);
        yield return new WaitForSeconds(1.25f);
        roomMonsterGrunt9.Play();
        yield return new WaitForSeconds(0.1f);
        radio.BreakRadio();
        radioAudio.Stop();
        radioPitch.TurnOffRadioLight();
        radioStatic.Stop();
        radioOff.Play();
        smashRadio.Play();
        clockAudio.volume = 0.6f;
        monsterBreathing.SetTargetVolume(0f, 3f);
        yield return new WaitForSeconds(1.6f);
        lightCrackle.Play();
        if (showFigure)
        {
            shadowManDoor.SetActive(false);
            shadowManRadio.SetActive(true);
        }
        monsterFade.SetAlphaTarget(15 / 255f, 0.15f);
        classroomLights.StartLightFlicker();
        roomMonsterGroan1.Play();
        yield return new WaitForSeconds(0.75f);
        monsterFade.SetAlphaTarget(0f, 0.75f);
        yield return new WaitForSeconds(2.5f);
        classroomLights.StopLightFlicker();
        lightCrackle.Stop();
        monsterFade.SetAlphaTarget(0f, 0.25f);
        monsterBreathing.SetTargetVolume(0.3f, 1f);

        yield return new WaitForSeconds(4.5f);

        //wlak over an break clock
        roomHeavyFootStep3.Play();
        monsterBreathing.SetTargetTransform(roomHeavyFootStep3.transform, 3f);
        yield return new WaitForSeconds(1.7f);
        roomHeavyFootStep4.Play();
        monsterBreathing.SetTargetTransform(roomHeavyFootStep4.transform, 3f);
        yield return new WaitForSeconds(1.65f);
        roomGlassStep3.Play();
        monsterBreathing.SetTargetTransform(roomGlassStep3.transform, 3f);
        monsterBreathing.SetTargetVolume(0f, 3f);
        yield return new WaitForSeconds(1f);
        //its a grunt swing not a groan
        roomMonsterGroan2.Play();
        monsterBreathing.SetTargetTransform(roomMonsterGroan2.transform, 3f);
        yield return new WaitForSeconds(0.5f);
        monsterBreathing.SetTargetVolume(0.3f, 1f);
        clock.SplitClock();
        clockBreak.Play();
        clockAudio.Stop();
        clockSecondHand.ClockBroke();

        yield return new WaitForSeconds(7f);

        //shake 1st desk
        desk1Lift.Play();
        desk1Animator.SetTrigger("Event2");
        monsterBreathing.SetTargetTransform(desk1Lift.transform, 3f);
        yield return new WaitForSeconds(1.4f);
        desk1Shake.Play();
        yield return new WaitForSeconds(2.35f);
        desk1Drop.Play();
        yield return new WaitForSeconds(2f);
        lightCrackle.Play();
        classroomLights.StartLightFlicker();
        roomMonsterFootStep5.Play();
        monsterBreathing.SetTargetTransform(roomMonsterFootStep5.transform, 3f);
        yield return new WaitForSeconds(1.7f);
        roomMonsterFootStep6.Play();
        monsterBreathing.SetTargetTransform(roomMonsterFootStep6.transform, 3f);
        classroomLights.StopLightFlicker();
        lightCrackle.Stop();
        yield return new WaitForSeconds(3f);

        //shake 2nd desk
        desk2Lift.Play();
        desk2Animator.SetTrigger("Event2");
        monsterBreathing.SetTargetTransform(desk2Lift.transform, 3f);
        yield return new WaitForSeconds(1.4f);
        desk2Shake.Play();
        yield return new WaitForSeconds(2.35f);
        desk2Drop.Play();
        yield return new WaitForSeconds(2f);
        roomMonsterFootStep7.Play();
        monsterBreathing.SetTargetTransform(roomMonsterFootStep7.transform, 3f);
        yield return new WaitForSeconds(1.7f);
        roomMonsterFootStep8.Play();
        monsterBreathing.SetTargetTransform(roomMonsterFootStep8.transform, 3f);

        yield return new WaitForSeconds(3f);

        monsterBreathing.SetTargetTransform(bookSmack.transform, 3f);
        lightCrackle.Play();
        classroomLights.StartLightFlicker();
        yield return new WaitForSeconds(1f);
        lightCrackle.Stop();
        classroomLights.StopLightFlicker();
        yield return new WaitForSeconds(0.25f);

        //smack book off desk
        roomMonsterGrunt8.Play();
        yield return new WaitForSeconds(0.1f);
        bookSmack.Play();
        throwBook.ThrowBookObject();
        yield return new WaitForSeconds(0.1f);
        bookCollide.Play();
        yield return new WaitForSeconds(0.25f);
        bookLand.Play();
        monsterBreathing.SetTargetVolume(0f, 3f);
        yield return new WaitForSeconds(2f);
        roomMonsterGroan3.Play();
        classroomLights.StartLightFlicker();
        lightCrackle.Play();
        if (showFigure)
        {
            shadowManRadio.SetActive(false);
            shadowManDesk.SetActive(true);
        }
        monsterFade.SetAlphaTarget(15 / 255f, 0.15f);
        yield return new WaitForSeconds(0.75f);
        monsterFade.SetAlphaTarget(0f, 0.75f);

        yield return new WaitForSeconds(2.40f);
        lightCrackle.Stop();
        classroomLights.StopLightFlicker();
        monsterFade.SetAlphaTarget(0f, 1f);
        monsterBreathing.SetTargetVolume(0.3f, 1f);

        yield return new WaitForSeconds(3.5f);

        //walk down aisle
        roomMonsterFootStep9.Play();
        monsterBreathing.SetTargetTransform(roomMonsterFootStep9.transform, 3f);
        yield return new WaitForSeconds(1.7f);
        roomMonsterFootStep10.Play();
        monsterBreathing.SetTargetTransform(roomMonsterFootStep10.transform, 3f);
        monsterBreathing.SetTargetVolume(0f, 3f);
        yield return new WaitForSeconds(1.65f);
        roomMonsterGrunt.Play();
        yield return new WaitForSeconds(0.2f);
        roomDesk1Hit.Play();
        roomDesk2Hit.Play();
        desk1.MoveDesk();
        desk2.MoveDesk();
        yield return new WaitForSeconds(2f);
        monsterBreathing.SetTargetVolume(0.3f, 1f);
        roomMonsterFootStep11.Play();
        monsterBreathing.SetTargetTransform(roomMonsterFootStep11.transform, 3f);
        yield return new WaitForSeconds(1.7f);
        roomMonsterFootStep12.Play();
        monsterBreathing.SetTargetTransform(roomMonsterFootStep12.transform, 3f);
        monsterBreathing.SetTargetVolume(0f, 3f);
        yield return new WaitForSeconds(1.65f);
        roomMonsterGrunt2.Play();
        yield return new WaitForSeconds(0.2f);
        roomDesk3Hit.Play();
        desk3.MoveDesk();
        yield return new WaitForSeconds(1f);
        monsterBreathing.SetTargetVolume(0.3f, 1f);
        yield return new WaitForSeconds(1f);
        monsterBreathing.SetTargetVolume(0f, 3f);
        yield return new WaitForSeconds(0.5f);
        roomMonsterGroan4.Play();
        lightCrackle.Play();
        if (showFigure)
        {
            shadowManDesk.SetActive(false);
            shadowManNearYou.SetActive(true);
        }
        monsterFade.SetAlphaTarget(15 / 255f, 0.15f);
        classroomLights.StartLightFlicker();
        yield return new WaitForSeconds(0.75f);
        monsterFade.SetAlphaTarget(0f, 0.75f);
        yield return new WaitForSeconds(2.45f);
        lightCrackle.Stop();
        classroomLights.StopLightFlicker();
        monsterFade.SetAlphaTarget(0f, 0.25f);
        monsterBreathing.SetTargetVolume(0.3f, 1f);

        yield return new WaitForSeconds(3f);

        ////delete
        //classroomLights.SetLightRange(8f, 1f);
        //throwBook.ThrowBookObject();
        //yield return new WaitForSeconds(1f);
        //desk1.MoveDesk();
        //desk2.MoveDesk();
        //yield return new WaitForSeconds(1f);

        ////end delete

        //fire alarm start
        fireAlarmLight.TurnOnLights(10f);
        fireAlarmLight.StartLightFlicker();
        fireAlarmSound.Play();
        monsterBreathing.SetTargetVolume(0f, 3f);
        yield return new WaitForSeconds(1f);
        roomMonsterGroan5.Play();
        lightCrackle.Play();
        classroomLights.StartLightFlicker();
        yield return new WaitForSeconds(2.1f);
        lightCrackle.Stop();
        classroomLights.StopLightFlicker();
        monsterBreathing.SetTargetVolume(0.3f, 1f);
        monsterBreathing.SetTargetTransform(roomMonsterFootStep13.transform, 3f);
        roomMonsterFootStep13.Play();
        yield return new WaitForSeconds(0.4f);
        roomMonsterFootStep14.Play();
        monsterBreathing.SetTargetTransform(roomMonsterFootStep14.transform, 3f);
        yield return new WaitForSeconds(0.45f);
        roomMonsterFootStep15.Play();
        monsterBreathing.SetTargetTransform(roomMonsterFootStep15.transform, 3f);
        yield return new WaitForSeconds(0.4f);
        roomMonsterFootStep16.Play();
        monsterBreathing.SetTargetTransform(roomMonsterFootStep16.transform, 3f);
        yield return new WaitForSeconds(0.45f);
        roomMonsterFootStep17.Play();
        monsterBreathing.SetTargetTransform(roomMonsterFootStep17.transform, 3f);
        monsterBreathing.SetTargetVolume(0f, 3f);
        yield return new WaitForSeconds(1f);

        roomMonsterGrunt3.Play();
        yield return new WaitForSeconds(0.25f);
        cabinetBreakSound.Play();
        cabinetDoor.BreakCabinet();
        yield return new WaitForSeconds(1f);
        roomMonsterGrunt4.Play();
        yield return new WaitForSeconds(0.25f);
        throwMonitor.ThrowObject();
        monitorSmackSound.Play();
        yield return new WaitForSeconds(1f);
        roomMonsterGrunt5.Play();
        yield return new WaitForSeconds(0.25f);
        monsterBreathing.SetTargetVolume(0.3f, 1f);
        fireAlarm.BreakFireAlarm();
        fireAlarmSound.Stop();
        monitorLandSound.Play();
        fireAlarmHitSound.Play();
        alarmGlassBreak.Play();
        fireAlarmLight.StopLightFlicker();
        yield return new WaitForSeconds(2.5f);
        monsterBreathing.SetTargetVolume(0f, 3f);
        yield return new WaitForSeconds(0.5f);
        lightCrackle.Play();
        if (showFigure)
        {
            shadowManNearYou.SetActive(false);
            shadowManFire.SetActive(true);
        }
        monsterFade.SetAlphaTarget(10 / 255f, 0.15f);
        classroomLights.StartLightFlicker();
        roomMonsterGroan6.Play();
        yield return new WaitForSeconds(0.75f);
        monsterFade.SetAlphaTarget(0f, 0.75f);
        yield return new WaitForSeconds(3.2f);
        lightCrackle.Stop();
        classroomLights.StopLightFlicker();
        monsterFade.SetAlphaTarget(0f, 0.25f);
        monsterBreathing.SetTargetVolume(0.3f, 1f);

        yield return new WaitForSeconds(5f);

        //getting out of here
        gettingOutOfHere.Play();
        yield return new WaitForSeconds(4f);
        roomLeavingFootStep3.Play();
        yield return new WaitForSeconds(1.25f);
        roomLeavingFootStep4.Play();
        monsterBreathing.SetTargetVolume(0f, 3f);
        yield return new WaitForSeconds(0.3f);
        lightCrackle.Play();
        if (showFigure)
        {
            shadowManFire.SetActive(false);
            shadowManFire2.SetActive(true);
        }
        monsterFade.SetAlphaTarget(10 / 255f, 0.15f);
        classroomLights.StartLightFlicker();
        roomMonsterGroan7.Play();
        yield return new WaitForSeconds(0.75f);
        monsterFade.SetAlphaTarget(0f, 0.75f);
        yield return new WaitForSeconds(1.25f);
        lightCrackle.Stop();
        monsterFade.SetAlphaTarget(0f, 0.25f);
        classroomLights.StopLightFlicker();
        monsterBreathing.SetTargetVolume(0.3f, 1f);
        yield return new WaitForSeconds(2.5f);
        pencilHolderAnimator.SetTrigger("Event2");
        cupSlide.Play();
        yield return new WaitForSeconds(2.5f);
        imSorry.Play();
        yield return new WaitForSeconds(1f);
        cupSlapSound.Play();
        pencil1.ThrowObject();
        pen1.ThrowObject();
        pen2.ThrowObject();
        cup.ThrowObject();
        yield return new WaitForSeconds(0.7f);
        groundClutternoise.Play();
        monsterBreathing.SetTargetVolume(0f, 3f);
        yield return new WaitForSeconds(0.25f);
        roomMonsterRoar.Play();
        lightCrackle.Play();
        classroomLights.StartLightFlicker();

        //radio turns back on
        radioStatic.Play();
        lightCrackle.Play();
        classroomLights.StartLightFlicker();
        radioAudio.Play();
        radioOn.Play();
        radioPitch.TurnOnRadioLight();
        radioPitch.ChangePitch(-1f, 1f);
        radioPitch.ChangeVolume(1f, 1f);
        radioPitch.ChangeSpecialBlend(0, 1f);

        yield return new WaitForSeconds(0.75f);


        //stomp to desks
        roomMonsterFootStep17.Play();
        yield return new WaitForSeconds(0.4f);
        roomMonsterFootStep16.Play();
        monsterBreathing.SetTargetTransform(roomMonsterFootStep16.transform, 3f);
        yield return new WaitForSeconds(0.45f);
        roomMonsterFootStep15.Play();
        monsterBreathing.SetTargetTransform(roomMonsterFootStep15.transform, 3f);
        yield return new WaitForSeconds(0.4f);
        roomMonsterFootStep14.Play();
        monsterBreathing.SetTargetTransform(roomMonsterFootStep14.transform, 3f);
        yield return new WaitForSeconds(0.45f);
        roomMonsterFootStep13.Play();
        monsterBreathing.SetTargetTransform(roomMonsterFootStep13.transform, 3f);
        desk2.ThrowDesk();
        desk2Throw.Play();
        roomMonsterGrunt6.Play();
        yield return new WaitForSeconds(0.5f);
        chairClatter1.Play();
        yield return new WaitForSeconds(0.5f);
        roomMonsterGrunt7.Play();
        desk1.ThrowDesk();
        desk1Throw.Play();
        yield return new WaitForSeconds(0.5f);
        chairClatter2.Play();
        yield return new WaitForSeconds(0.5f);
        roomMonsterFootStep13.Play();
        yield return new WaitForSeconds(0.5f);
        roomMonsterFootStep18.Play();
        monsterBreathing.SetTargetTransform(roomMonsterFootStep18.transform, 3f);
        yield return new WaitForSeconds(0.35f);
        roomMonsterLiftGrunt.Play();
        playerDeskAnimator.SetTrigger("Event2");
        playerPencilAnimator.SetTrigger("Event2");
        playerPaperAnimator.SetTrigger("Event2");
        if (showFigure)
        {
            shadowManFire2.SetActive(false);
        }
        yield return new WaitForSeconds(3f);
        monsterEnding.gameObject.SetActive(true);


    }

    public void ShowEndingMonster()
    {
        StartCoroutine(EndingRoutine());
    }

    private IEnumerator EndingRoutine()
    {
        if (showFigure)
        {
            shadowManEnd.SetActive(true);
        }
        monsterFade.SetAlphaTarget(1f, 100f);
        roomMonsterFinalSound.Play();
        yield return new WaitForSeconds(0.5f);
        blackOut.FadeInBlocker(null, 100);
        lightCrackle.Stop();
        yield return new WaitForSeconds(5f);
        radioPitch.ChangeVolume(0f, 1f);
        radioStatic.Stop();
        Debug.Log("Total Time: " + experienceLength);
        yield return new WaitForSeconds(3f);

        SceneLoader.Instance.LoadScene("EndScreenSilence");
    }

}
