using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggeredObject : MonoBehaviour
{

    [Header("Object")]
    [SerializeField] private bool turnOnObject;
    [SerializeField] private GameObject myGameobject;

    [Header("Light")]
    [SerializeField] private bool startLightFlicker;
    [SerializeField] private Lighting objectLight;

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

    }

}
