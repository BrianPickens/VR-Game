using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//require a Box Collider so that there is a target to hit
[RequireComponent(typeof(BoxCollider))]
[RequireComponent(typeof(AudioSource))]

public class LookTarget : MonoBehaviour
{
    [SerializeField]
    protected AudioClip SoundClip = null;

    [SerializeField]
    protected float MaxVolume = 1f;

    protected bool isLookedAt = false;

    protected bool isPressable = false;

    protected AudioSource myAudioSource = null;

    protected virtual void Awake()
    {
        myAudioSource = GetComponent<AudioSource>();
        if (myAudioSource != null)
        {
            myAudioSource.volume = 0f;
            myAudioSource.clip = SoundClip;
        }
    }

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

    public bool GetPressableStatus()
    {
        return isPressable;
    }

}
