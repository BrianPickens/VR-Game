using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LittlePumpkin : MonoBehaviour
{
    [SerializeField] private Transform myTransform = null;
    
    [SerializeField] private Animator myAnimator = null;

    [SerializeField] private bool idleStand = false;
    [SerializeField] private bool idleCrawl = false;

    [SerializeField] private Transform endingPosition = null;

    [SerializeField] private float moveSpeed = 1f;

    [SerializeField] private Transform currentTarget = null;

    private Vector3 target = Vector3.zero;

    private bool alive = false;
    private bool idleStarted = false;

    private void Start()
    {
        Appear();
    }

    public void Appear()
    {

        if (idleStand)
        {
            int randomCoin = Random.Range(0, 2);
            if (randomCoin == 1)
            {
                myAnimator.SetTrigger("Walk1");
            }
            else
            {
                myAnimator.SetTrigger("Walk2");
            }
        }
        else if(idleCrawl)
        {
            myAnimator.SetTrigger("Crawl");
        }

        alive = true;

    }

    private void Update()
    {

        if (!alive)
        {
            return;
        }


        target = new Vector3(currentTarget.position.x, myTransform.position.y, currentTarget.position.z);
        myTransform.LookAt(target);

        if (Mathf.Abs(Vector3.Distance(myTransform.position, endingPosition.position)) > Mathf.Epsilon)
        {
            myTransform.position = Vector3.MoveTowards(myTransform.position, endingPosition.position, Time.deltaTime * moveSpeed);
        }
        else
        {
            if (!idleStarted)
            {
                if (idleStand)
                {
                    myAnimator.SetTrigger("Idle");
                }
                else
                {
                    myAnimator.SetTrigger("CrawlIdle");
                }
                idleStarted = true;
            }
        }
    }

}
