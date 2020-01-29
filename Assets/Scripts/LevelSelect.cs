using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;



public class LevelSelect : MonoBehaviour
{

    [Serializable]
    private class LevelInfo
    {
        public string LevelID = null;
        public Sprite LevelImage = null;
        public string LevelText = null;
    }

    [SerializeField]
    private CameraBlackOut BlackOutScreen = null;

    [SerializeField]
    private LevelDisplay LevelDisplay = null;

    [SerializeField]
    private CanvasGroup MyCanvasGroup = null;

    [SerializeField]
    private float FadeSpeed = 1f;

    [SerializeField]
    private LookButton BackButton = null;

    [SerializeField]
    private StageSelectButton StartingButton = null;

    [SerializeField]
    private LookButton StarteLevelButton = null;

    [SerializeField]
    private List<LevelInfo> levels = new List<LevelInfo>();

    private StageSelectButton lastButton = null;

    private string currentSelectedLevelID = null;

    public Action OnFadeOutCompleted;

    public Action OnFadeInCompleted;



    public void Start()
    {
        currentSelectedLevelID = "Room";
        lastButton = StartingButton;
        lastButton.SetAsPressed();
        StarteLevelButton.MakeButtonPressable(true);
    }

    public void FadeInLevelSelect(Action _callback = null)
    {
        OnFadeInCompleted = null;
        OnFadeInCompleted = _callback;
        MyCanvasGroup.alpha = 0f;
        gameObject.SetActive(true);
        StartCoroutine(FadeIn());
    }

    public void FadeOutLevelSelect(Action _callback = null)
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
        MakeButtonsPressable();
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
        BackButton.ResetButton();
    }


    private void MakeButtonsPressable()
    {
        BackButton.MakeButtonPressable(true);
    }

    public void LevelButtonSelected(string _LevelID, StageSelectButton _buttonPressed)
    {

        if (lastButton != _buttonPressed)
        {
            lastButton.MakeButtonPressable(true);
            lastButton = _buttonPressed;
            lastButton.SetAsPressed();
        }

        LevelInfo selectedLevel = null;
        for (int i = 0; i < levels.Count; i++)
        {
            if (_LevelID == levels[i].LevelID)
            {
                selectedLevel = levels[i];
                break;
            }
        }

        if (selectedLevel != null)
        {
            if (selectedLevel.LevelID != currentSelectedLevelID)
            {
                currentSelectedLevelID = selectedLevel.LevelID;
                DisplayLevelInfo(selectedLevel);
            }
        }
        else
        {
            Debug.LogError("Couldn't find selected level");
        }
    }

    private void DisplayLevelInfo(LevelInfo _levelInfo)
    {
        LevelDisplay.DisplayStageInfo(_levelInfo.LevelImage, _levelInfo.LevelText);
    }

    public void StartLevelPressed()
    {
        Debug.Log("Start level: " + currentSelectedLevelID);

        //fade out main camera and load using scene loader
        BlackOutScreen.FadeInBlocker(LoadLevel);
    }

    public void LoadLevel()
    {
        SceneLoader.Instance.LoadScene(currentSelectedLevelID);
    }
}
