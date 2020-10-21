using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinTimeline : MonoBehaviour
{
    [SerializeField] private LookTargeting targeting = null;
    [SerializeField] private CameraBlackOut blackOut = null;
    [SerializeField] private Lighting playerLight = null;
    [SerializeField] private float lightRangeChange = 5f;
    [SerializeField] private float musicVolumeChange = 0.1f;
    [SerializeField] private float heartBeatVolumeChange = 0.1f;
    [SerializeField] private float heartBeatPitchChange = 0.4f;

    [SerializeField] private IntroPopUpText interactionTutorial = null;

    [Header("Trigger Buttons")]
    [SerializeField] private TriggerButton candleLeftButton = null;
    [SerializeField] private TriggerButton candleRightButton = null;

    [SerializeField] private TriggerButton eyeLeftButton = null;
    [SerializeField] private TriggerButton eyeRightButton = null;

    [SerializeField] private TriggerButton topLockButton = null;
    [SerializeField] private TriggerButton middleLockButton = null;
    [SerializeField] private TriggerButton bottomLockButton = null;

    [SerializeField] private TriggerButton candleLeftButtonSecond = null;
    [SerializeField] private TriggerButton candleRightButtonSecond = null;

    [Header("Animators")]
    [SerializeField] private Animator lockCoverAnimator = null;
    [SerializeField] private Animator chestAnimator = null;

    [Header("Objects")]
    [SerializeField] private GameObject rightFlameThrower = null;
    [SerializeField] private GameObject leftFlameThrower = null;
    [SerializeField] private GameObject rightFlame = null;
    [SerializeField] private GameObject leftFlame = null;

    [Header("Particle System")]
    [SerializeField] private ParticleSystem rightFlameParticleSystem = null;
    [SerializeField] private ParticleSystem leftFlameParticleSystem = null;
    [SerializeField] private ParticleSystem rightFlameThrowerParticleSystem = null;
    [SerializeField] private ParticleSystem leftFlameThrowerParticleSystem = null;

    [Header("Misc")]
    [SerializeField] private BounceRandom rightLightBounce = null;
    [SerializeField] private BounceRandom leftLigthBounce = null;

    [SerializeField] private Lighting rightLight = null;
    [SerializeField] private Lighting leftLight = null;

    [Header("Sound Sources")]
    [SerializeField] private SoundSource backgroundMusic = null;
    [SerializeField] private SoundSource candleLeftAudio = null;
    [SerializeField] private SoundSource candleRightAudio = null;
    [SerializeField] private SoundSource candleLeftStartAudio = null;
    [SerializeField] private SoundSource candleRightStartAudio = null;
    [SerializeField] private SoundSource knock1 = null;
    [SerializeField] private SoundSource knock2 = null;
    [SerializeField] private SoundSource knock3 = null;
    [SerializeField] private SoundSource heartBeatSlow = null;
    [SerializeField] private SoundSource heartBeatFast = null;
    [SerializeField] private SoundSource leftEyeAudio = null;
    [SerializeField] private SoundSource rightEyeAudio = null;
    [SerializeField] private SoundSource knock4 = null;
    [SerializeField] private SoundSource knock5 = null;
    [SerializeField] private SoundSource knock6 = null;
    [SerializeField] private SoundSource lockCoverUnlock = null;
    [SerializeField] private SoundSource lockCoverSqueak = null;
    [SerializeField] private SoundSource lockCoverLand = null;
    [SerializeField] private SoundSource topLockUnLock = null;
    [SerializeField] private SoundSource middleLockUnlock = null;
    [SerializeField] private SoundSource bottomLockUnlock = null;
    [SerializeField] private SoundSource woodCreak = null;
    [SerializeField] private SoundSource woodScratching = null;
    [SerializeField] private SoundSource chestOpening = null;
    [SerializeField] private SoundSource scaryEscapeSound = null;
    [SerializeField] private SoundSource rightFlameThrowerAudio = null;
    [SerializeField] private SoundSource leftFlameThrowerAudio = null;
    [SerializeField] private SoundSource rightFlameThrowerStart = null;
    [SerializeField] private SoundSource leftFlameThrowerStart = null;
    [SerializeField] private SoundSource creepyFireStop = null;
    [SerializeField] private SoundSource chestOpenAll = null;
    [SerializeField] private SoundSource creepyPumpkinBGMusic = null;

    private int triggerCount = 0;

    private void Start()
    {
        targeting.DisableTargeting();
        blackOut.FadeOutBlocker(ShowInteractionTutorial);
        backgroundMusic.SetTargetVolume(0.01f, 10f);
    }

    private void ShowInteractionTutorial()
    {
        interactionTutorial.FadeInPopUp();
        targeting.EnableTargeting();
    }

    public void InteractionTutorialCompleted()
    {
        interactionTutorial.FadeOutPopUp(RunStory);
    }

    private void RunStory()
    {
        StartCoroutine(RevealCandlesTriggers());
    }

    private IEnumerator RevealCandlesTriggers()
    {
        yield return new WaitForSeconds(1f);
        candleLeftButton.InitializeButton(ObjectTriggered);
        candleLeftButton.AddCallback(IncreasePlayerLight);
        candleLeftButton.AddCallback(IncreaseBackgroundMusic);
        candleLeftButton.AddCallback(() =>
        {
            candleLeftStartAudio.PlayAudio();
        });
        candleLeftButton.AddCallback(() =>
        {
            candleLeftAudio.SetTargetVolume(0.6f, 10f);
            candleLeftAudio.PlayAudio();
        });
        yield return new WaitForSeconds(1f);
        candleRightButton.InitializeButton(ObjectTriggered);
        candleRightButton.AddCallback(IncreasePlayerLight);
        candleRightButton.AddCallback(IncreaseBackgroundMusic);
        candleRightButton.AddCallback(() =>
        {
            candleRightStartAudio.PlayAudio();
        });
        candleRightButton.AddCallback(() =>
        {
            candleRightAudio.SetTargetVolume(0.6f, 10f);
            candleRightAudio.PlayAudio();
        });
    }

    private void ObjectTriggered()
    {
        triggerCount++;
        if (triggerCount == 2)
        {
            StartCoroutine(RevealEyeTriggers());
        }

        if (triggerCount == 4)
        {
            StartCoroutine(RevealLockTriggers());
        }

        if (triggerCount == 7)
        {
            StartCoroutine(ReleasePumpkin());
        }

        if (triggerCount == 9)
        {
            StartCoroutine(RevealPumpkins());
        }
    }

    private IEnumerator RevealEyeTriggers()
    {
        targeting.DisableTargeting();

        yield return new WaitForSeconds(5f);
        knock1.PlayAudio();
        yield return new WaitForSeconds(2f);
        knock2.PlayAudio();
        yield return new WaitForSeconds(2f);
        knock3.PlayAudio();
        yield return new WaitForSeconds(2f);
        eyeLeftButton.InitializeButton(ObjectTriggered);
        eyeLeftButton.AddCallback(IncreaseBackgroundMusic);
        eyeLeftButton.AddCallback(IncreaseHeartBeatSound);
        eyeLeftButton.AddCallback(() =>
        {
            leftEyeAudio.PlayAudio();
        });
        yield return new WaitForSeconds(1f);
        eyeRightButton.InitializeButton(ObjectTriggered);
        eyeRightButton.AddCallback(IncreaseBackgroundMusic);
        eyeRightButton.AddCallback(IncreaseHeartBeatSound);
        eyeRightButton.AddCallback(() =>
        {
            rightEyeAudio.PlayAudio();
        });

        heartBeatSlow.PlayAudio();
        targeting.EnableTargeting();

    }
    private IEnumerator RevealLockTriggers()
    {
        targeting.DisableTargeting();

        yield return new WaitForSeconds(5f);
        knock4.PlayAudio();
        yield return new WaitForSeconds(2f);
        knock5.PlayAudio();
        yield return new WaitForSeconds(2f);
        knock6.PlayAudio();
        yield return new WaitForSeconds(0.5f);

        lockCoverUnlock.PlayAudio();
        lockCoverAnimator.SetTrigger("Event2");
        yield return new WaitForSeconds(0.6f);
        lockCoverSqueak.PlayAudio();
        yield return new WaitForSeconds(0.9f);
        lockCoverLand.PlayAudio();


        yield return new WaitForSeconds(1f);

        topLockButton.InitializeButton(ObjectTriggered);
        topLockButton.AddCallback(IncreaseBackgroundMusic);
        topLockButton.AddCallback(IncreaseHeartBeatSound);
        topLockButton.AddCallback(IncreaseHeartBeatPitch);
        topLockButton.AddCallback(() =>
        {
            topLockUnLock.PlayAudioWithDelay(0.25f);
        });
        yield return new WaitForSeconds(1f);
        middleLockButton.InitializeButton(ObjectTriggered);
        middleLockButton.AddCallback(IncreaseBackgroundMusic);
        middleLockButton.AddCallback(IncreaseHeartBeatSound);
        middleLockButton.AddCallback(IncreaseHeartBeatPitch);
        middleLockButton.AddCallback(() =>
        {
            middleLockUnlock.PlayAudioWithDelay(0.25f);
        });
        yield return new WaitForSeconds(1f);
        bottomLockButton.InitializeButton(ObjectTriggered);
        bottomLockButton.AddCallback(IncreaseBackgroundMusic);
        bottomLockButton.AddCallback(IncreaseHeartBeatSound);
        bottomLockButton.AddCallback(IncreaseHeartBeatPitch);
        bottomLockButton.AddCallback(() =>
        {
            bottomLockUnlock.PlayAudioWithDelay(0.25f);
        });
        targeting.EnableTargeting();
    }

    private IEnumerator ReleasePumpkin()
    {
        targeting.DisableTargeting();
        yield return new WaitForSeconds(1f);
        heartBeatSlow.SetTargetPitch(3f, 0.1f);
        heartBeatSlow.SetTargetVolume(1f, 0.1f);
        heartBeatSlow.SetTargetMinDistance(5f, 0.4f);
        yield return new WaitForSeconds(9.4f);
        creepyFireStop.PlayAudio();
        rightFlameParticleSystem.Stop();
        leftFlameParticleSystem.Stop();
        rightLight.SetLightRange(0, 10f);
        leftLight.SetLightRange(0, 10f);
        playerLight.ChangeLightRangeByAmount(-lightRangeChange * 2, 10f);
        yield return new WaitForSeconds(0.6f);
        heartBeatSlow.SetTargetVolume(0f, 100f);
        backgroundMusic.SetTargetVolume(0f, 100f);
        candleRightAudio.SetTargetVolume(0f, 100f);
        candleLeftAudio.SetTargetVolume(0f, 100f);

        //heartBeatSlow.StopAudio();
        //backgroundMusic.StopAudio();
        //candleRightAudio.StopAudio();
        //candleLeftAudio.StopAudio();


        yield return new WaitForSeconds(5f);
        woodScratching.PlayAudio();
        yield return new WaitForSeconds(4f);
        woodCreak.PlayAudio();
        yield return new WaitForSeconds(4f);
        rightFlameThrower.SetActive(true);
        leftFlameThrower.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        rightFlameThrowerStart.PlayAudio();
        leftFlameThrowerStart.PlayAudio();
        rightFlameThrowerAudio.PlayAudio();
        leftFlameThrowerAudio.PlayAudio();
        rightLightBounce.SetSpeeds(0.5f, 0.7f);
        leftLigthBounce.SetSpeeds(0.5f, 0.7f);
        rightLight.SetLightRange(30f, 10f);
        leftLight.SetLightRange(30f, 10f);
        rightLight.SetFlickerIntensity(3f);
        leftLight.SetFlickerIntensity(3f);

        //playe fire sound

        yield return new WaitForSeconds(5f);
        knock4.PlayAudio();
        yield return new WaitForSeconds(2f);
        knock5.PlayAudio();
        yield return new WaitForSeconds(2f);
        chestOpening.PlayAudio();
        chestAnimator.SetTrigger("Event2");
        rightFlameThrowerParticleSystem.Stop();
        leftFlameThrowerParticleSystem.Stop();
        rightLight.SetLightRange(0, 25f);
        leftLight.SetLightRange(0, 25);
        playerLight.SetLightRange(0, 25f);
        rightLightBounce.SetSpeeds(0f, 0f);
        leftLigthBounce.SetSpeeds(0f, 0f);
        yield return new WaitForSeconds(0.6f);
        leftFlameThrowerAudio.StopAudio();
        rightFlameThrowerAudio.StopAudio();
        chestOpenAll.PlayAudio();
        yield return new WaitForSeconds(5f);
        chestAnimator.SetTrigger("Event3");
        creepyPumpkinBGMusic.PlayAudio();
        creepyPumpkinBGMusic.SetTargetVolume(0.25f, 0.005f);
        backgroundMusic.StopAudio();
        yield return new WaitForSeconds(1f);
        backgroundMusic.PlayAudio();
        backgroundMusic.SetTargetVolume(0.4f, 0.005f);
        //play pumpkin stand and step forward animation
        //star making smaller pumpkins appear and walk in

        yield return new WaitForSeconds(10f);

        //show the candle trigger buttons
        candleLeftButtonSecond.InitializeButton(ObjectTriggered);
        candleLeftButtonSecond.AddCallback(() =>
        {
            backgroundMusic.ChangeVolumeByAmount(musicVolumeChange, 0.25f);
            playerLight.ChangeLightRangeByAmount(5f, 10f);
            candleLeftStartAudio.PlayAudio();
            leftLight.SetLightRange(10f, 25f);
            leftLigthBounce.SetSpeeds(0.1f, 0.2f);
            leftFlameParticleSystem.Play();
            candleLeftAudio.SetTargetVolume(0.6f, 10f);
            candleLeftAudio.PlayAudio();
        });

        yield return new WaitForSeconds(1f);

        candleRightButtonSecond.InitializeButton(ObjectTriggered);
        candleRightButtonSecond.AddCallback(() =>
        {
            backgroundMusic.ChangeVolumeByAmount(musicVolumeChange, 0.25f);
            playerLight.ChangeLightRangeByAmount(5f, 10f);
            candleRightStartAudio.PlayAudio();
            rightLight.SetLightRange(10f, 25f);
            rightLightBounce.SetSpeeds(0.1f, 0.2f);
            rightFlameParticleSystem.Play();
            candleRightAudio.SetTargetVolume(0.6f, 10f);
            candleRightAudio.PlayAudio();
        });

        targeting.EnableTargeting();
    }

    private IEnumerator RevealPumpkins()
    {
        creepyPumpkinBGMusic.SetTargetVolume(0.1f, 0.01f);
        yield return null;
    }

    private void IncreaseBackgroundMusic()
    {
        backgroundMusic.ChangeVolumeByAmount(musicVolumeChange, 1f);
    }

    private void IncreasePlayerLight()
    {
        playerLight.ChangeLightRangeByAmount(lightRangeChange, 5f);
    }

    private void IncreaseHeartBeatSound()
    {
        heartBeatSlow.ChangeVolumeByAmount(heartBeatVolumeChange, 1f);
    }

    private void IncreaseHeartBeatPitch()
    {
        heartBeatSlow.ChangePitchByAmount(heartBeatPitchChange, 1f);
    }


}
