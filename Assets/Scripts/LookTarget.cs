using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//require a Box Collider so that there is a target to hit
[RequireComponent(typeof(BoxCollider))]
[RequireComponent(typeof(AudioSource))]

public class LookTarget : MonoBehaviour
{
    [SerializeField]
    private AudioClip SoundClip = null;

    [SerializeField]
    private float MaxVolume = 1f;

    [SerializeField]
    private float FadeSpeed = 1f;

    protected bool isLookedAt = false;

    protected AudioSource myAudioSource = null;

    private IEnumerator soundRoutine = null;

    private void Awake()
    {
        myAudioSource = GetComponent<AudioSource>();
        myAudioSource.volume = 0f;
        myAudioSource.clip = SoundClip;
        myAudioSource.Play();
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
        //transfer all of this to look button, and make a separate sound response for toggle button because
        //you need it to play differently
        if (SoundClip != null)
        {
            if (!myAudioSource.isPlaying)
            {
                myAudioSource.Play();
            }

            if (soundRoutine != null)
            {
                StopCoroutine(soundRoutine);
            }
            soundRoutine = SoundRoutine(true);
            StartCoroutine(soundRoutine);
        }
    }

    protected virtual void EndLookResponse()
    {
        if (SoundClip != null)
        {
            if (soundRoutine != null)
            {
                StopCoroutine(soundRoutine);
            }
            soundRoutine = SoundRoutine(false);
            StartCoroutine(soundRoutine);
        }
    }

    private IEnumerator SoundRoutine(bool _fadeIn)
    {
        if (_fadeIn)
        {
            while (Mathf.Abs(myAudioSource.volume - MaxVolume) > Mathf.Epsilon)
            {
                myAudioSource.volume = Mathf.MoveTowards(myAudioSource.volume, MaxVolume, FadeSpeed * Time.deltaTime);
                yield return null;
            }
        }
        else
        {
            while (Mathf.Abs(myAudioSource.volume - 0) > Mathf.Epsilon)
            {
                myAudioSource.volume = Mathf.MoveTowards(myAudioSource.volume, 0f, FadeSpeed * Time.deltaTime);
                yield return null;
            }
        }
    }

}
