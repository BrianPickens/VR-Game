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

    [SerializeField]
    private Image HighlightedBackground = null;

    [SerializeField]
    private float FillSpeed = 10f;

    private bool buttonPressed = false;

    private bool isPressable = false;

    private bool fillOutline = false;

    protected override void Awake()
    {
        base.Awake();
        myAudioSource.volume = MaxVolume;
    }

    private void Update()
    {
        MoveHighlightedFill();
    }

    private void MoveHighlightedFill()
    {
        if (fillOutline)
        {
            HighlightedBackground.fillAmount = Mathf.MoveTowards(HighlightedBackground.fillAmount, 1f, FillSpeed * Time.deltaTime);
        }
        else
        {
            HighlightedBackground.fillAmount = Mathf.MoveTowards(HighlightedBackground.fillAmount, 0f, FillSpeed * Time.deltaTime);
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
        fillOutline = true;
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
        fillOutline = true;
        buttonPressed = true;
        ButtonPressedEvent.Invoke(LevelID, this);
    }

    public void MakeButtonPressable(bool _isPressable)
    {
        fillOutline = false;
        FillImage.fillAmount = 0f;
        buttonPressed = false;
        isPressable = _isPressable;
    }

    public void ResetButton()
    {
        fillOutline = false;
        FillImage.fillAmount = 0f;
        buttonPressed = false;
        isPressable = false;
    }

    public void SetAsPressed()
    {
        fillOutline = true;
        FillImage.fillAmount = 1f;
        buttonPressed = true;
        isPressable = false;
    }

}
