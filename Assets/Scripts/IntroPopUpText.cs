using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class IntroPopUpText : MonoBehaviour
{

    [SerializeField]
    private CanvasGroup myCanvasGroup = null;

    [SerializeField]
    private float fadeSpeed = 1f;

    [SerializeField]
    LookButton myButton = null;

    public Action OnFadeOutCompleted;

    public void FadeInPopUp()
    {
        myCanvasGroup.alpha = 0f;
        gameObject.SetActive(true);
        StartCoroutine(FadeIn());
    }

    public void FadeOutPopUp(Action _callback)
    {
        OnFadeOutCompleted = null;
        OnFadeOutCompleted = _callback;
        StartCoroutine(FadeOut());
    }

    private IEnumerator FadeIn()
    {
        while (myCanvasGroup.alpha < 1f)
        {
            myCanvasGroup.alpha = Mathf.MoveTowards(myCanvasGroup.alpha, 1f, fadeSpeed * Time.deltaTime);
            yield return null;
        }

        myCanvasGroup.alpha = 1f;
        myButton.MakeButtonPressable(true);

    }

    private IEnumerator FadeOut()
    {
        while (myCanvasGroup.alpha > 0f)
        {
            myCanvasGroup.alpha = Mathf.MoveTowards(myCanvasGroup.alpha, 0f, fadeSpeed * Time.deltaTime);
            yield return null;
        }

        myCanvasGroup.alpha = 0f;
        if (OnFadeOutCompleted != null)
        {
            OnFadeOutCompleted();
        }
    }
}
