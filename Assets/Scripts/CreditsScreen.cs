using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsScreen : MonoBehaviour
{

    [SerializeField]
    private CameraBlackOut BlackOut;

    [SerializeField]
    private LookButton MenuButton;

    private void Start()
    {
        BlackOut.FadeOutBlocker();
        MenuButton.MakeButtonPressable(true);
    }

    public void MenuPressed()
    {
        BlackOut.FadeInBlocker(LoadMainMenu);
    }

    private void LoadMainMenu()
    {
        StaticInfo.Instance.SetSkipIntro(true);
        SceneLoader.Instance.LoadScene("TitleScreen");
    }

}
