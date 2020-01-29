using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelDisplay : MonoBehaviour
{

    [SerializeField]
    private Image LevelImage = null;

    [SerializeField]
    private Text LevelText = null;

    [SerializeField]
    private CanvasGroup LevelCanvasGroup = null;

    [SerializeField]
    private float FadeSpeed = 1f;

    public void DisplayStageInfo(Sprite _background, string _levelText)
    {
        StopAllCoroutines();
        StartCoroutine(ChangeLevelInfoRoutine(_background, _levelText));
    }

    private IEnumerator ChangeLevelInfoRoutine(Sprite _background, string _levelText)
    {
        while (LevelCanvasGroup.alpha > 0f)
        {
            LevelCanvasGroup.alpha = Mathf.MoveTowards(LevelCanvasGroup.alpha, 0f, FadeSpeed * Time.deltaTime);
            yield return null;
        }

        LevelCanvasGroup.alpha = 0f;
        LevelImage.sprite = _background;
        LevelText.text = _levelText;

        while (LevelCanvasGroup.alpha < 1f)
        {
            LevelCanvasGroup.alpha = Mathf.MoveTowards(LevelCanvasGroup.alpha, 1f, FadeSpeed * Time.deltaTime);
            yield return null;
        }

        LevelCanvasGroup.alpha = 1f;

    }

}
