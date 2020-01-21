using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{

    [SerializeField]
    private IntroPopUpText LookTutorialPopUp = null;

    [SerializeField]
    private IntroPopUpText SeizureWarningPopUp = null;

    //need to remember to turn down volume on whispers as the text is fading out

    private void Start()
    {
        ShowLookTutorialPopUp();
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
        //when completed, need to open the main menu
    }


}
