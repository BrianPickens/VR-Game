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
    //need to remember to turn down volume on whispers as the text is fading out

    private void Start()
    {
        BlackOutScreen.FadeOutBlocker(ShowLogo);
    }

    public void ShowLogo()
    {
        LogoPopUp.ShowLogoDisplaySequence(null, ShowLookTutorialPopUp);
    }

    public void ShowLookTutorialPopUp()
    {
        LookTutorialPopUp.FadeInPopUp();
    }

    public void LookTutorialCompleted()
    {
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
        LevelSelect.FadeInLevelSelect();
    }

    public void ReturnFromLevelSelect()
    {
        LevelSelect.FadeOutLevelSelect(ShowLandingPage);
    }

}
