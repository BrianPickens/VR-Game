using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookTargeting : MonoBehaviour
{
    private LookTarget currentLookTarget = null;

    private void Update()
    {
        CheckForLookTarget();
    }

    //Check to see if we are looking at anything interactive
    private void CheckForLookTarget()
    {
        RaycastHit hitInfo;
        Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward, Color.green);
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hitInfo, 100.0f, 1 << 8))
        {
            LookTarget currentTarget = hitInfo.transform.GetComponent<LookTarget>();
            if (currentTarget != currentLookTarget)
            {
                //end the look of our last object if we didn't already end it while looking around
                if (currentLookTarget != null)
                {
                    Debug.Log("Stopped Looking At: " + currentLookTarget.name);
                    currentLookTarget.LookEnded();
                }

                Debug.Log("Started Looking At: " + currentTarget.name);

                //set new look target
                currentLookTarget = currentTarget;

                //start look at new target
                currentLookTarget.LookStarted();
            }
        }
        else
        {
            //if we look away we end the look at our last target, and null it out
            if (currentLookTarget != null)
            {
                Debug.Log("Stopped Looking At: " + currentLookTarget.name);
                currentLookTarget.LookEnded();
                currentLookTarget = null;
            }
        }


    }
}
