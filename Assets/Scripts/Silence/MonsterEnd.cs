using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterEnd : LookTarget
{
    [SerializeField] private SilenceTimeline silenceTimeline = null;

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
        silenceTimeline.ShowEndingMonster();
    }



}
