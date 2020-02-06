using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System;

[Serializable]
public class StageButtonEvent : UnityEvent<string, StageSelectButton> { }

public class StageSelectButton : LookTarget
{
    [SerializeField]
    StageButtonEvent ButtonPressedEvent = null;

    [SerializeField]
    private string LevelID = null;

    [SerializeField]
    private Image FillImage = null;

    private bool buttonPressed = false;

    private bool isPressable = false;


    protected override void Awake()
    {
        base.Awake();
        myAudioSource.volume = MaxVolume;
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
        FillImage.fillAmount = 1f;
        if (!buttonPressed)
        {
            myAudioSource.PlayOneShot(SoundClip);
        }
        ButtonPressed();
        //add selection sounds
    }


    protected override void EndLookResponse()
    {
        base.EndLookResponse();
    }

    private void ButtonPressed()
    {
        LookEnded();
        buttonPressed = true;
        ButtonPressedEvent.Invoke(LevelID, this);
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

    public void SetAsPressed()
    {
        FillImage.fillAmount = 1f;
        buttonPressed = true;
        isPressable = false;
    }

}
