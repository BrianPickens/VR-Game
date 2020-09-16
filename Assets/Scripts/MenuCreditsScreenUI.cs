using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCreditsScreenUI : IntroPopUpText
{
    [SerializeField]
    private LookButton BackButton = null;

    [SerializeField]
    private LookButton InstagramButton = null;

    [SerializeField]
    private LookButton TwitterButton = null;

    public void MakeButtonsPressable()
    {
        InstagramButton.MakeButtonPressable(true);
        TwitterButton.MakeButtonPressable(true);
        BackButton.MakeButtonPressable(true);
    }

    public void BlockButtons()
    {
        InstagramButton.MakeButtonPressable(false);
        TwitterButton.MakeButtonPressable(false);
        BackButton.MakeButtonPressable(false);
    }

    public void InstagramPress()
    {
        InstagramButton.ResetButton();
        InstagramButton.MakeButtonPressable(true);
        Application.OpenURL("https://www.instagram.com/realtoughchickens/");
    }

    public void TwitterPress()
    {
        TwitterButton.ResetButton();
        TwitterButton.MakeButtonPressable(true);
        Application.OpenURL("https://twitter.com/Tough_Chickens");
    }

}
