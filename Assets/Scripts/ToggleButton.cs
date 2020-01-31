using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleButton : LookTarget
{


    [SerializeField]
    private Image FillImage = null;

    private bool buttonPressed = false;

    private bool isPressable = false;

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
    }

    protected override void EndLookResponse()
    {
        base.EndLookResponse();
        FillImage.fillAmount = 0f;
    }

    public bool GetLookStatus()
    {
        return isLookedAt;
    }

}
