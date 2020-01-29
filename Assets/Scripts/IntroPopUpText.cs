using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class IntroPopUpText : MonoBehaviour
{

    [SerializeField]
    private CanvasGroup MyCanvasGroup = null;

    [SerializeField]
    private float FadeSpeed = 1f;

    [SerializeField]
    protected LookButton MyButton = null;

    public Action OnFadeOutCompleted;

    public Action OnFadeInCompleted;

    public void FadeInPopUp(Action _callback = null)
    {
        OnFadeInCompleted = null;
        OnFadeInCompleted = _callback;
        MyCanvasGroup.alpha = 0f;
        gameObject.SetActive(true);
        StartCoroutine(FadeIn());
    }

    public void FadeOutPopUp(Action _callback = null)
    {
        OnFadeOutCompleted = null;
        OnFadeOutCompleted = _callback;
        StartCoroutine(FadeOut());
    }

    private IEnumerator FadeIn()
    {
        while (MyCanvasGroup.alpha < 1f)
        {
            MyCanvasGroup.alpha = Mathf.MoveTowards(MyCanvasGroup.alpha, 1f, FadeSpeed * Time.deltaTime);
            yield return null;
        }

        MyCanvasGroup.alpha = 1f;
        MyButton.MakeButtonPressable(true);
        if (OnFadeInCompleted != null)
        {
            OnFadeInCompleted();
        }
    }

    private IEnumerator FadeOut()
    {
        while (MyCanvasGroup.alpha > 0f)
        {
            MyCanvasGroup.alpha = Mathf.MoveTowards(MyCanvasGroup.alpha, 0f, FadeSpeed * Time.deltaTime);
            yield return null;
        }

        MyCanvasGroup.alpha = 0f;
        if (OnFadeOutCompleted != null)
        {
            OnFadeOutCompleted();
        }
        MyButton.ResetButton();
        gameObject.SetActive(false);
    }
}
