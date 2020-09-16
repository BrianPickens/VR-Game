using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighting : MonoBehaviour
{
    [SerializeField]
    private List<Light> primaryLights = new List<Light>();

    [SerializeField]
    private float flickerSpeed = 1f;

    [SerializeField]
    private float flickerDistance = 1f;

    [SerializeField]
    private float flickerIntensity = 1f;

    [SerializeField]
    private float lightChangeSpeed = 30f;

    private bool flickerLights = false;

    [SerializeField]
    private float targetRange = 55f;

    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Alpha1))
        //{
        //    flickerLights = !flickerLights;
        //}

        //if (Input.GetKeyDown(KeyCode.Alpha2))
        //{
        //    SetLightRange(10f,30f);
        //}

        //if (Input.GetKeyDown(KeyCode.Alpha3))
        //{
        //    SetLightRange(55f,30f);
        //}

        if (flickerLights)
        {
            float intensity = Mathf.PingPong(Time.time * flickerSpeed, flickerDistance) + flickerIntensity;
            for (int i = 0; i < primaryLights.Count; i++)
            {
                if (primaryLights[i].gameObject.activeInHierarchy)
                {
                    float change = (intensity - flickerIntensity) * 2;
                    primaryLights[i].intensity = intensity - change;
                }
            }
        }

        if (Mathf.Abs(primaryLights[0].range - targetRange) > Mathf.Epsilon)
        {
            for (int i = 0; i < primaryLights.Count; i++)
            {
                primaryLights[i].range = Mathf.MoveTowards(primaryLights[i].range, targetRange, Time.deltaTime * lightChangeSpeed);
            }
        }

    }

    public void StartLightFlicker()
    {
        flickerIntensity = primaryLights[0].intensity;
        flickerLights = true;
    }

    public void StopLightFlicker()
    {
        flickerLights = false;
        for (int i = 0; i < primaryLights.Count; i++)
        {
            if (primaryLights[i].gameObject.activeInHierarchy)
            {
                primaryLights[i].intensity = flickerIntensity;
            }
        }
    }

    public void SetLightRange(float _range, float _changeSpeed)
    {
        targetRange = _range;
        lightChangeSpeed = _changeSpeed;
    }

    public void TurnOffLights()
    {
        targetRange = 0f;
        for (int i = 0; i < primaryLights.Count; i++)
        {
            if (primaryLights[i].gameObject.activeInHierarchy)
            {
                primaryLights[i].range = 0f;
            }
        }
    }

    public void TurnOnLights(float _range)
    {
        targetRange = _range;
        for (int i = 0; i < primaryLights.Count; i++)
        {
            if (primaryLights[i].gameObject.activeInHierarchy)
            {
                primaryLights[i].range = _range;
            }
        }
    }




    }