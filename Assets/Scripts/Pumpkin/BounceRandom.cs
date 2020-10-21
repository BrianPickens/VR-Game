using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceRandom : MonoBehaviour
{

    [SerializeField] private Transform myTransform;
    [SerializeField] private float maxOffset;
    [SerializeField] private float minSpeed;
    [SerializeField] private float maxSpeed;

    private float minY = 0;
    private float maxY = 0;

    private float targetY = 0;
    private float currentSpeed = 0;

    private Vector3 targetVector = Vector3.zero;

    private bool movingUp = true;

    private void Start()
    {
        minY = myTransform.position.y;
        maxY = myTransform.position.y + maxOffset;
        GetNewTargetY();
    }

    private void Update()
    {
        if (Mathf.Abs(myTransform.position.y - targetY) > Mathf.Epsilon)
        {
            myTransform.position = Vector3.MoveTowards(myTransform.position, targetVector, Time.deltaTime * currentSpeed);
        }
        else
        {
            movingUp = !movingUp;
            GetNewTargetY();
        }
    }

    private void GetNewTargetY()
    {
        float rangeTop = maxY;
        float rangeBot = minY;

        if (movingUp)
        {
            rangeBot = myTransform.position.y;
        }
        else
        {
            rangeTop = myTransform.position.y;
        }

        targetY = Random.Range(rangeBot, rangeTop);
        currentSpeed = Random.Range(minSpeed, maxSpeed);

        targetVector = new Vector3(myTransform.position.x, targetY, myTransform.position.z);
    }

    public void SetSpeeds(float _minSpeed, float _maxSpeed)
    {
        minSpeed = _minSpeed;
        maxSpeed = _maxSpeed;
        movingUp = !movingUp;
        GetNewTargetY();
    }

}
