﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Reticle : MonoBehaviour
{

    [SerializeField]
    private Animator MyAnimator = null;

    [SerializeField]
    private Image MyReticle = null;

    [SerializeField]
    private Sprite RedReticle = null;

    [SerializeField]
    private Sprite WhiteReticle = null;

    public void LookingAtTarget()
    {
        MyReticle.sprite = RedReticle;
        MyAnimator.SetBool("Grow", true);
    }

    public void StoppedLookingAtTarget()
    {
        MyReticle.sprite = WhiteReticle;
        MyAnimator.SetBool("Grow", false);
    }

}
