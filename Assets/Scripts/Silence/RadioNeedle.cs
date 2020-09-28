using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioNeedle : MonoBehaviour
{

    [SerializeField] private Transform myTransform = null;
    [SerializeField] private Transform position1 = null;
    [SerializeField] private Transform position2 = null;
    [SerializeField] private float needleSpeed = 1f;
    private Vector3 currentTarget = Vector3.zero;

    private bool moveNeedle = false;

    private void Start()
    {
        currentTarget = position1.position;
    }

    private void Update()
    {
        if (moveNeedle)
        {
            myTransform.position = Vector3.MoveTowards(myTransform.position, currentTarget, Time.deltaTime * needleSpeed);
            if (Mathf.Abs(Vector3.Distance(myTransform.position, currentTarget)) < Mathf.Epsilon)
            {
                if (currentTarget == position1.position)
                {
                    currentTarget = position2.position;
                }
                else
                {
                    currentTarget = position1.position;
                }
            }

        }

    }

    public void StartNeedle()
    {
        moveNeedle = true;
    }

    public void StopNeedle()
    {
        moveNeedle = false;
    }


}
