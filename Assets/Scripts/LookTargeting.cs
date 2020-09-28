using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookTargeting : MonoBehaviour
{
    [SerializeField]
    private Reticle reticle = null;

    private LookTarget currentLookTarget = null;

    private bool canTarget = true;

    private void Update()
    {
        if (canTarget)
        {
            CheckForLookTarget();
        }
    }

    //Check to see if we are looking at anything interactive
    private void CheckForLookTarget()
    {
        RaycastHit hitInfo;
        Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward, Color.green);
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hitInfo, 100.0f, 1 << 8))
        {
            LookTarget currentTarget = hitInfo.transform.GetComponent<LookTarget>();

            if (!currentTarget.GetPressableStatus())
            {
                return;
            }

            if (currentTarget != currentLookTarget)
            {
                //end the look of our last object if we didn't already end it while looking around
                if (currentLookTarget != null)
                {
                    //Debug.Log("Stopped Looking At: " + currentLookTarget.name);
                    currentLookTarget.LookEnded();
                }

               // Debug.Log("Started Looking At: " + currentTarget.name);

                //set new look target
                currentLookTarget = currentTarget;

                //start look at new target
                currentLookTarget.LookStarted();
                reticle.LookingAtTarget();
            }

        }
        else
        {
            //if we look away we end the look at our last target, and null it out
            if (currentLookTarget != null)
            {
                //Debug.Log("Stopped Looking At: " + currentLookTarget.name);
                currentLookTarget.LookEnded();
                currentLookTarget = null;
                reticle.StoppedLookingAtTarget();
            }
        }
    }

    public void DisableTargeting()
    {
        canTarget = false;
    }

    public void EnableTargeting()
    {
        canTarget = true;
    }
}
