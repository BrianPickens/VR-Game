using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockSecondHand : MonoBehaviour
{

    [SerializeField]
    private Transform clockHand = null;

    [SerializeField]
    private float rotationSpeed = 20f;

    private bool broken = false;

    void Update()
    {
        if (!broken)
        {
            clockHand.RotateAround(Vector3.right, rotationSpeed * Time.deltaTime);
        }
    }

    public void ClockBroke()
    {
        broken = true;
    }

}
