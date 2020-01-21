using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//require a Box Collider so that there is a target to hit
[RequireComponent(typeof(BoxCollider))]

public class LookTarget : MonoBehaviour
{
    protected bool isLookedAt = false;

    public virtual void LookStarted()
    {
        if (!isLookedAt)
        {
            isLookedAt = true;
            StartLookResponse();
        }
    }

    public virtual void LookEnded()
    {
        if (isLookedAt)
        {
            isLookedAt = false;
            EndLookResponse();
        }
    }

    protected virtual void StartLookResponse()
    {

    }

    protected virtual void EndLookResponse()
    {

    }

}
