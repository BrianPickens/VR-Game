using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReticleText : MonoBehaviour
{

    [SerializeField]
    private CanvasGroup MyCanvasGroup = null;

    private IEnumerator FadeRoutine;

    public void HideText()
    {
        MyCanvasGroup.alpha = 0f;
    }

    public void FadeInText()
    {
        if (FadeRoutine != null)
        {
            StopCoroutine(FadeRoutine);
        }

        FadeRoutine = FadeInCo();
        StartCoroutine(FadeRoutine);
    }

    public void FadeOutText()
    {
        if (FadeRoutine != null)
        {
            StopCoroutine(FadeRoutine);
        }
        FadeRoutine = FadeOutCo();
        StartCoroutine(FadeRoutine);
    }

    private IEnumerator FadeInCo()
    {
        while (MyCanvasGroup.alpha < 1f)
        {
            MyCanvasGroup.alpha = Mathf.MoveTowards(MyCanvasGroup.alpha, 1f, Time.deltaTime);
            yield return null;
        }
        MyCanvasGroup.alpha = 1f;
    }

    private IEnumerator FadeOutCo()
    {
        while (MyCanvasGroup.alpha > 0f)
        {
            MyCanvasGroup.alpha = Mathf.MoveTowards(MyCanvasGroup.alpha, 0f, Time.deltaTime);
            yield return null;
        }
        MyCanvasGroup.alpha = 0f;
    }

}
