using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggeredObject : MonoBehaviour
{

    [Header("Object")]
    [SerializeField] private bool turnOnObject = false;
    [SerializeField] private GameObject myGameobject = null;

    [Header("Light")]
    [SerializeField] private bool startLightFlicker = false;
    [SerializeField] private Lighting objectLight = null;

    [Header("Animator")]
    [SerializeField] private bool playAnimation = false;
    [SerializeField] private int animationNum = 0;
    [SerializeField] private Animator myAnimator = null;

    public void TriggerResponse()
    {
        if (turnOnObject)
        {
            myGameobject.SetActive(true);
        }

        if (startLightFlicker)
        {
            objectLight.StartLightFlicker();
        }

        if (playAnimation)
        {
            switch (animationNum)
            {
                case 1:
                    myAnimator.SetTrigger("Event1");
                    break;

                case 2:
                    myAnimator.SetTrigger("Event2");
                    break;

                case 3:
                    myAnimator.SetTrigger("Event3");
                    break;

                case 4:
                    myAnimator.SetTrigger("Event4");
                    break;

                default:
                    myAnimator.SetTrigger("Event1");
                    break;
            }
        }

    }

}
