using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LandingScreenUI : IntroPopUpText
{
    [SerializeField]
    private LookButton PrivacyPolicyButton = null;

    public void BlockButtons()
    {
        MyButton.MakeButtonPressable(false);
        PrivacyPolicyButton.MakeButtonPressable(false);
    }

    public void MakeButtonsPressable()
    {
        MyButton.MakeButtonPressable(true);
        PrivacyPolicyButton.MakeButtonPressable(true);
    }

    public void MakePrivacyPolicyPressable()
    {
        PrivacyPolicyButton.MakeButtonPressable(true);
    }

    public void ResetPrivacyPolicyButton()
    {
        PrivacyPolicyButton.ResetButton();
    }

    public void ResetBeginButton()
    {
        MyButton.ResetButton();
    }


}
