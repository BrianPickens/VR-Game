using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System;

[Serializable]
public class ButtonEvent : UnityEvent {}

public class LookButton : LookTarget
{
    [SerializeField]
    ButtonEvent ButtonPressedEvent = null;

    [SerializeField]
    private Image FillImage = null;

    [SerializeField]
    private float FillSpeed = 1f;

    [SerializeField]
    protected float SoundFadeSpeed = 1f;

    [SerializeField]
    protected bool RandomAudioStart = false;

    private bool musicStarted = false;

    private bool buttonPressed = false;

    private IEnumerator soundRoutine = null;

    protected override void Awake()
    {
        base.Awake();
        if (RandomAudioStart)
        {
            if (SoundClip != null)
            {
                myAudioSource.time = UnityEngine.Random.Range(0, SoundClip.length);
            }
        }
        myAudioSource.Play();
    }

    protected virtual void Update()
    {
        MoveFill();
    }

    protected void MoveFill()
    {
        if (!buttonPressed && isPressable)
        {
            if (isLookedAt)
            {
                FillImage.fillAmount = Mathf.MoveTowards(FillImage.fillAmount, 1f, FillSpeed * Time.deltaTime);
                if (SoundClip != null && !musicStarted)
                {
                    if (!myAudioSource.isPlaying)
                    {
                        myAudioSource.Play();
                    }

                    if (soundRoutine != null)
                    {
                        StopCoroutine(soundRoutine);
                    }
                    musicStarted = true;
                    soundRoutine = SoundRoutine(true);
                    StartCoroutine(soundRoutine);
                }
            }
            else
            {
                FillImage.fillAmount = Mathf.MoveTowards(FillImage.fillAmount, 0f, FillSpeed * Time.deltaTime);

            }

            if (FillImage.fillAmount >= 0.99f)
            {
                ButtonPressed();
            }
        }

    }

    public override void LookStarted()
    {
        base.LookStarted();
    }

    public override void LookEnded()
    {
        base.LookEnded();
    }

    protected override void StartLookResponse()
    {
        base.StartLookResponse();
    }


    protected override void EndLookResponse()
    {
        base.EndLookResponse();
        if (SoundClip != null && musicStarted)
        {
            if (soundRoutine != null)
            {
                StopCoroutine(soundRoutine);
            }
            soundRoutine = SoundRoutine(false);
            musicStarted = false;
            StartCoroutine(soundRoutine);
        }
    }

    private void ButtonPressed()
    {
        LookEnded();
        buttonPressed = true;
        ButtonPressedEvent.Invoke();
    }

    public void MakeButtonPressable(bool _isPressable)
    {
        FillImage.fillAmount = 0f;
        buttonPressed = false;
        isPressable = _isPressable;
    }

    public void ResetButton()
    {
        FillImage.fillAmount = 0f;
        buttonPressed = false;
        isPressable = false;
    }

        private IEnumerator SoundRoutine(bool _fadeIn)
    {
        if (_fadeIn)
        {
            while (Mathf.Abs(myAudioSource.volume - MaxVolume) > Mathf.Epsilon)
            {
                myAudioSource.volume = Mathf.MoveTowards(myAudioSource.volume, MaxVolume, SoundFadeSpeed * Time.deltaTime);
                yield return null;
            }
        }
        else
        {
            while (Mathf.Abs(myAudioSource.volume - 0) > Mathf.Epsilon)
            {
                myAudioSource.volume = Mathf.MoveTowards(myAudioSource.volume, 0f, SoundFadeSpeed * Time.deltaTime);
                yield return null;
            }
        }
    }

    public void SetAsPressed()
    {
        FillImage.fillAmount = 1f;
        buttonPressed = true;
        isPressable = false;
    }

}
