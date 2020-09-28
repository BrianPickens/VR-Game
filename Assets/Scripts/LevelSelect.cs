using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;



public class LevelSelect : MonoBehaviour
{

    private enum StageType { Experiential, Interactive };

    [Serializable]
    private class LevelInfo
    {
        public string LevelID = null;
        public Sprite LevelImage = null;
        public string LevelText = null;
    }

    [SerializeField] private LookTargeting lookTargeting = null;

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
    private Image NotAvaliableImage = null;

    [SerializeField] private StageSelectButton StartingButtonExperiential = null;
    [SerializeField] private StageSelectButton StartingButtonInteractive = null;


    [SerializeField]
    private LookButton StartLevelButton = null;

    [SerializeField] private LookButton ExperientialButton = null;
    [SerializeField] private LookButton InteractiveButton = null;

    [SerializeField] private StageHolderUI ExperientialStageHolder = null;
    [SerializeField] private StageHolderUI InteractiveStageHolder = null;

    [SerializeField]
    private List<LevelInfo> levels = new List<LevelInfo>();

    private StageSelectButton lastButton = null;

    private string currentSelectedLevelID = null;

    public Action OnFadeOutCompleted;

    public Action OnFadeInCompleted;

    private bool levelStarting = false;

    private StageType currentStageType = StageType.Experiential;

    public void Start()
    {
        //ExperientialStageHolder.ShowStageHolder();
        //InteractiveStageHolder.HideStageHolder();
        lastButton = StartingButtonExperiential;
        lastButton.SetAsPressed();


        LevelButtonSelected("Room", lastButton);
        NotAvaliableImage.gameObject.SetActive(false);
    }

    public void FadeInLevelSelect(Action _callback = null)
    {
        OnFadeInCompleted = null;
        OnFadeInCompleted = _callback;
        MyCanvasGroup.alpha = 0f;
        gameObject.SetActive(true);
        switch (currentStageType)
        {
            case StageType.Experiential:
                ExperientialButton.SetAsPressed();
                break;

            case StageType.Interactive:
                InteractiveButton.SetAsPressed();
                break;

            default:
                Debug.LogError("Unknown enum in MakeButtonsPressable");
                break;
        }
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
        //stops them from auto filling if they fade out and come back when someone is looking at them
        StartLevelButton.LookEnded();
        InteractiveButton.LookEnded();
        ExperientialButton.LookEnded();

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

        MakeButtonsInactive();
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
        StartLevelButton.MakeButtonPressable(true);

        switch (currentStageType)
        {
            case StageType.Experiential:
                InteractiveButton.MakeButtonPressable(true);
                break;

            case StageType.Interactive:
                ExperientialButton.MakeButtonPressable(true);
                break;

            default:
                Debug.LogError("Unknown enum in MakeButtonsPressable");
                break;
        }

    }

    private void MakeButtonsInactive()
    {
        StartLevelButton.MakeButtonPressable(false);
        switch (currentStageType)
        {
            case StageType.Experiential:
                InteractiveButton.MakeButtonPressable(false);
                break;

            case StageType.Interactive:
                ExperientialButton.MakeButtonPressable(false);
                break;

            default:
                Debug.LogError("Unknown enum in MakeButtonsPressable");
                break;
        }
    }

    public void LevelButtonSelected(string _LevelID, StageSelectButton _buttonPressed)
    {

        if (levelStarting)
        {
            //stop player from accidently changing the level while the fade out is happenign to load
            return;
        }

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

        if (currentSelectedLevelID == "")
        {
            StartLevelButton.MakeButtonPressable(false);
            NotAvaliableImage.gameObject.SetActive(true);
        }
        else
        {
            StartLevelButton.MakeButtonPressable(true);
            NotAvaliableImage.gameObject.SetActive(false);
        }
    }

    public void StartLevelPressed()
    {
        Debug.Log("Start level: " + currentSelectedLevelID);

        //fade out main camera and load using scene loader
        BackButton.MakeButtonPressable(false);
        levelStarting = true;
        lookTargeting.DisableTargeting();
        BlackOutScreen.FadeInBlocker(LoadLevel);
    }

    public void LoadLevel()
    {
        SceneLoader.Instance.LoadScene(currentSelectedLevelID);
    }

    public void ExperientialButtonPressed()
    {
        currentStageType = StageType.Experiential;
        BackButton.MakeButtonPressable(false);
        InteractiveButton.MakeButtonPressable(false);
        StartLevelButton.MakeButtonPressable(false);
        ExperientialButton.SetAsPressed();
        InteractiveStageHolder.FadeOut(ShowExperientialStageHolder);
    }

    public void ShowExperientialStageHolder()
    {
        lastButton.ResetButton();
        lastButton.MakeButtonPressable(true);
        lastButton = StartingButtonExperiential;
        lastButton.SetAsPressed();
        LevelButtonSelected("Room", lastButton);
        ExperientialStageHolder.FadeIn(ExperientialStageFadedIn);
    }

    public void ExperientialStageFadedIn()
    {
        BackButton.MakeButtonPressable(true);
        InteractiveButton.MakeButtonPressable(true);
        StartLevelButton.MakeButtonPressable(true);
    }

    public void InteractiveButtonPressed()
    {
        currentStageType = StageType.Interactive;
        BackButton.MakeButtonPressable(false);
        ExperientialButton.MakeButtonPressable(false);
        StartLevelButton.MakeButtonPressable(false);
        InteractiveButton.SetAsPressed();
        ExperientialStageHolder.FadeOut(ShowInteractiveStageHolder);
    }

    public void ShowInteractiveStageHolder()
    {
        lastButton.ResetButton();
        lastButton.MakeButtonPressable(true);
        lastButton = StartingButtonInteractive;
        lastButton.SetAsPressed();
        LevelButtonSelected("Pumpkin", lastButton);
        InteractiveStageHolder.FadeIn(InteractiveStageFadedIn);
    }

    public void InteractiveStageFadedIn()
    {
        BackButton.MakeButtonPressable(true);
        ExperientialButton.MakeButtonPressable(true);
        StartLevelButton.MakeButtonPressable(true);
    }


}
