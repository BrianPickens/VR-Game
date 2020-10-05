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

    [SerializeField] private IntroPopUpText interactionTutorial = null;

    [SerializeField] private TriggerButton candleLeftButton = null;
    [SerializeField] private TriggerButton candleRightButton = null;

    [SerializeField] private TriggerButton eyeLeftButton = null;
    [SerializeField] private TriggerButton eyeRightButton = null;

    [SerializeField] private TriggerButton topLockButton = null;
    [SerializeField] private TriggerButton middleLockButton = null;
    [SerializeField] private TriggerButton bottomLockButton = null;

    private int triggerCount = 0;

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
    [SerializeField] private SoundSource topLockUnLock = null;
    [SerializeField] private SoundSource middleLockUnlock = null;
    [SerializeField] private SoundSource bottomLockUnlock = null;

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
            ReleasePumpkin();
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

        yield return new WaitForSeconds(5f);
        knock4.PlayAudio();
        yield return new WaitForSeconds(2f);
        knock5.PlayAudio();
        yield return new WaitForSeconds(2f);
        knock6.PlayAudio();
        yield return new WaitForSeconds(2f);

        targeting.DisableTargeting();
        yield return new WaitForSeconds(1f);
        topLockButton.InitializeButton(ObjectTriggered);
        topLockButton.AddCallback(IncreaseBackgroundMusic);
        topLockButton.AddCallback(IncreaseHeartBeatSound);
        topLockButton.AddCallback(() =>
        {
            topLockUnLock.PlayAudio();
        });
        yield return new WaitForSeconds(1f);
        middleLockButton.InitializeButton(ObjectTriggered);
        middleLockButton.AddCallback(IncreaseBackgroundMusic);
        middleLockButton.AddCallback(IncreaseHeartBeatSound);
        middleLockButton.AddCallback(() =>
        {
            middleLockUnlock.PlayAudio();
        });
        yield return new WaitForSeconds(1f);
        bottomLockButton.InitializeButton(ObjectTriggered);
        bottomLockButton.AddCallback(IncreaseBackgroundMusic);
        bottomLockButton.AddCallback(IncreaseHeartBeatSound);
        bottomLockButton.AddCallback(() =>
        {
            bottomLockUnlock.PlayAudio();
        });
        targeting.EnableTargeting();
    }       

    private void ReleasePumpkin()
    {

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


}
