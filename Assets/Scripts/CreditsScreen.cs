using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsScreen : MonoBehaviour
{

    [SerializeField]
    private CameraBlackOut BlackOut = null;

    [SerializeField]
    private float MenuButtonFadeSpeed = 1f;

    [SerializeField]
    private CanvasGroup MenuButtonCanvasGroup = null;

    [SerializeField]
    private LookButton MenuButton= null;

    [SerializeField]
    private LookButton InstagramButton = null;

    [SerializeField]
    private LookButton TwitterButton = null;

    private void Start()
    {
        BlackOut.FadeOutBlocker();
        MenuButtonCanvasGroup.alpha = 0f;
        InstagramButton.MakeButtonPressable(true);
        TwitterButton.MakeButtonPressable(true);
        StartCoroutine(MenuButtonDelayCo());
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

    private IEnumerator MenuButtonDelayCo()
    {
        yield return new WaitForSeconds(4f);
        while (MenuButtonCanvasGroup.alpha < 0.95f)
        {
            MenuButtonCanvasGroup.alpha = Mathf.MoveTowards(MenuButtonCanvasGroup.alpha, 1f, Time.deltaTime * MenuButtonFadeSpeed);
            yield return null;
        }
        MenuButtonCanvasGroup.alpha = 1f;
        MenuButton.MakeButtonPressable(true);

    }

}
