using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Reticle : MonoBehaviour
{

    [SerializeField]
    private Animator MyAnimator = null;


    public void LookingAtTarget()
    {
        MyAnimator.SetBool("Grow", true);
    }

    public void StoppedLookingAtTarget()
    {
        MyAnimator.SetBool("Grow", false);
    }

}
