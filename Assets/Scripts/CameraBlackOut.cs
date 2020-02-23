using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CameraBlackOut : MonoBehaviour
{
    [SerializeField]
    private CanvasGroup MyCanvasGroup = null;

    [SerializeField]
    private float FadeSpeed = 1f;

    private IEnumerator FadeOutRoutine;

    private IEnumerator FadeinRoutine;

    public Action OnFadeOutCompleted;

    public Action OnFadeInCompleted;

    public void FadeInBlocker(Action _callback = null, float _fadeSpeed = 1f)
    {
        FadeSpeed = _fadeSpeed;
        if (FadeOutRoutine != null)
        {
            StopCoroutine(FadeOutRoutine);

            if (OnFadeOutCompleted != null)
            {
                OnFadeOutCompleted();
            }

            OnFadeOutCompleted = null;
            FadeOutRoutine = null;
        }

        OnFadeInCompleted = null;
        OnFadeInCompleted = _callback;
        MyCanvasGroup.alpha = 0f;
        gameObject.SetActive(true);
        FadeinRoutine = FadeIn();
        StartCoroutine(FadeinRoutine);
    }

    public void FadeOutBlocker(Action _callback = null, float _fadeSpeed = 1f)
    {
        FadeSpeed = _fadeSpeed;
        if (FadeinRoutine != null)
        {
            StopCoroutine(FadeinRoutine);

            if (OnFadeInCompleted != null)
            {
                OnFadeInCompleted();
            }

            OnFadeInCompleted = null;
            FadeinRoutine = null;
        }
        OnFadeOutCompleted = null;
        OnFadeOutCompleted = _callback;
        MyCanvasGroup.alpha = 1f;
        gameObject.SetActive(true);
        FadeOutRoutine = FadeOut();
        StartCoroutine(FadeOutRoutine);
    }

    private IEnumerator FadeIn()
    {
        while (MyCanvasGroup.alpha < 0.99f)
        {
            MyCanvasGroup.alpha = Mathf.MoveTowards(MyCanvasGroup.alpha, 1f, FadeSpeed * Time.deltaTime);
            yield return null;
        }

        MyCanvasGroup.alpha = 1f;
        if (OnFadeInCompleted != null)
        {
            OnFadeInCompleted();
        }

        OnFadeInCompleted = null;
    }

    private IEnumerator FadeOut()
    {
        while (MyCanvasGroup.alpha > 0.01f)
        {
            MyCanvasGroup.alpha = Mathf.MoveTowards(MyCanvasGroup.alpha, 0f, FadeSpeed * Time.deltaTime);
            yield return null;
        }

        MyCanvasGroup.alpha = 0f;
        if (OnFadeOutCompleted != null)
        {
            OnFadeOutCompleted();
        }

        OnFadeOutCompleted = null;

        gameObject.SetActive(false);
    }

}
