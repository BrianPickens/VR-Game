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

    private bool buttonPressed = false;

    private bool isPressable = false;

    private void Update()
    {
        MoveFill();
    }

    private void MoveFill()
    {
        if (!buttonPressed && isPressable)
        {
            if (isLookedAt)
            {
                FillImage.fillAmount = Mathf.MoveTowards(FillImage.fillAmount, 1f, FillSpeed * Time.deltaTime);
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
        //DON'T FORGET TO ADD WHISPERING SOUNDS BACK IN WHEN YOU REDO THE SOUND SYSTEM
    }


    protected override void EndLookResponse()
    {
        //maybe reset button when we look away if it was pressed?
        base.EndLookResponse();
    }

    private void ButtonPressed()
    {
        buttonPressed = true;
        ButtonPressedEvent.Invoke();
    }

    public void MakeButtonPressable(bool _isPressable)
    {
        isPressable = _isPressable;
    }

    public void ResetButton()
    {
        FillImage.fillAmount = 0f;
        buttonPressed = false;
    }

}
