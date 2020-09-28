using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField]
    private CameraBlackOut BlackOutScreen = null;

    [SerializeField]
    private LogoIntro LogoPopUp = null;

    [SerializeField]
    private IntroPopUpText LookTutorialPopUp = null;

    [SerializeField]
    private IntroPopUpText SeizureWarningPopUp = null;

    [SerializeField]
    private LandingScreenUI LandingScreen = null;

    [SerializeField]
    private LevelSelect LevelSelect = null;

    [SerializeField]
    private MenuCreditsScreenUI MenuCredits = null;

    [SerializeField]
    private ReticleText ReticleText = null;

    private void Start()
    {
        if (!StaticInfo.Instance.SkipIntro)
        {
            BlackOutScreen.FadeOutBlocker(ShowLogo);
        }
        else
        {
            BlackOutScreen.FadeOutBlocker(ShowLandingPage);
        }

        ReticleText.HideText();
    }

    public void ShowLogo()
    {
        LogoPopUp.ShowLogoDisplaySequence(null, ShowLookTutorialPopUp);
    }

    public void ShowLookTutorialPopUp()
    {
        LookTutorialPopUp.FadeInPopUp();
        ReticleText.FadeInText();
    }

    public void LookTutorialCompleted()
    {
        ReticleText.FadeOutText();
        LookTutorialPopUp.FadeOutPopUp(ShowSeizureWarningPopUp);
    }

    public void ShowSeizureWarningPopUp()
    {
        SeizureWarningPopUp.FadeInPopUp();
    }

    public void SeizureWarningConfirmed()
    {
        SeizureWarningPopUp.FadeOutPopUp(ShowLandingPage); 
    }

    public void ShowLandingPage()
    {
        LandingScreen.BlockButtons();
        LandingScreen.FadeInPopUp(LandingScreen.MakeButtonsPressable);
    }

    public void PrivacyPolicyPressed()
    {
        LandingScreen.ResetPrivacyPolicyButton();
        LandingScreen.MakePrivacyPolicyPressable();
        Application.OpenURL("http://brianpickensgames.com/PrivacyPolicyItsInHere.html");
    }

    public void BeginPressed()
    {
        LandingScreen.FadeOutPopUp(ShowLevelSelect);
    }

    public void ShowLevelSelect()
    {
        LandingScreen.EndLookOnButtons();
        LevelSelect.FadeInLevelSelect();
    }

    public void ReturnFromLevelSelect()
    {
        LevelSelect.FadeOutLevelSelect(ShowLandingPage);
    }

    public void CreditsPressed()
    {
        LandingScreen.BlockButtons();
        LandingScreen.FadeOutPopUp(ShowCreditsPage);
    }

    public void ShowCreditsPage()
    {
        LandingScreen.EndLookOnButtons();
        MenuCredits.BlockButtons();
        MenuCredits.FadeInPopUp(MenuCredits.MakeButtonsPressable);
    }

    public void ReturnFromCredits()
    {
        MenuCredits.BlockButtons();
        MenuCredits.FadeOutPopUp(ShowLandingPage);
    }

}
