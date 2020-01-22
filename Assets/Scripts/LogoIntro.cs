using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LogoIntro : MonoBehaviour
{
    [SerializeField]
    private CanvasGroup MyCanvasGroup = null;

    [SerializeField]
    private float FadeSpeed = 1f;

    public Action OnFadeOutCompleted;

    public Action OnFadeInCompleted;

    public void ShowLogoDisplaySequence(Action _fadeInCallback = null, Action _fadeOutCallback = null)
    {
        OnFadeInCompleted = null;
        OnFadeInCompleted = _fadeInCallback;
        OnFadeOutCompleted = null;
        OnFadeOutCompleted = _fadeOutCallback;
        MyCanvasGroup.alpha = 0f;
        gameObject.SetActive(true);
        StartCoroutine(FadeIn());
    }

    private void FadeOutPopUp()
    {
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
        if (OnFadeInCompleted != null)
        {
            OnFadeInCompleted();
        }

        yield return new WaitForSeconds(1.5f);
        FadeOutPopUp();
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
        gameObject.SetActive(false);
    }
}
