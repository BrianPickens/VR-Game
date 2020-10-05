using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TriggerButton : LookButton
{
    [SerializeField] private GameObject parent = null;

    [SerializeField] private TriggeredObject myObject = null;

    [SerializeField] private Transform myTransform = null;

    [SerializeField] private Transform targetTransform = null;

    [SerializeField] private Animator myAnimator = null;

    private bool initialized = false;

    public Action OnButtonTriggered;

    public void InitializeButton(Action callback = null)
    {
        gameObject.SetActive(true);
        myAnimator.SetTrigger("Intro");
        OnButtonTriggered += callback;
        targetTransform = Camera.main.transform;
        MakeButtonPressable(true);
        initialized = true;
    }

    public void AddCallback(Action callback = null)
    {
        OnButtonTriggered += callback;
    }

    public void ButtonPressed()
    {
        if (myObject != null)
        {
            myObject.TriggerResponse();
        }
        OnButtonTriggered?.Invoke();
        myAnimator.SetTrigger("Outro");
        Invoke("TurnOffParent", 0.7f);
    }

    protected override void Update()
    {
        base.Update();
        if (initialized)
        {
            myTransform.LookAt(targetTransform);
        }
    }

    private void TurnOffParent()
    {
        parent.SetActive(false);
    }
}
