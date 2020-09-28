using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class StageHolderUI : MonoBehaviour
{

    [SerializeField] private CanvasGroup MyCanvasGroup = null;

    [SerializeField] private float FadeSpeed = 1f;

    public Action OnFadeOutCompleted;

    public Action OnFadeInCompleted;

    public void FadeIn(Action _callback = null)
    {
        OnFadeInCompleted = null;
        OnFadeInCompleted = _callback;
        MyCanvasGroup.alpha = 0f;
        gameObject.SetActive(true);
        StartCoroutine(FadeIn());
    }

    public void FadeOut(Action _callback = null)
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
        gameObject.SetActive(false);

    }

    public void ShowStageHolder()
    {
        gameObject.SetActive(true);
        MyCanvasGroup.alpha = 1f;
    }

    public void HideStageHolder()
    {
        gameObject.SetActive(false);
        MyCanvasGroup.alpha = 0f;
    }
}
