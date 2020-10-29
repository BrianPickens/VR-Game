using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinEnd : LookTarget
{
    [SerializeField] private PumpkinTimeline pumpkinTimeline = null;

    private bool triggered = false;

    private void Start()
    {
        isPressable = true;
    }

    protected override void StartLookResponse()
    {
        base.StartLookResponse();
        if (!triggered)
        {
            triggered = true;
            MonsterLookedAt();
        }
    }

    private void MonsterLookedAt()
    {
        pumpkinTimeline.PlayPumpkinScare();
    }
}
