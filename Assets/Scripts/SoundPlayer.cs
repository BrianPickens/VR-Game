using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{

    [SerializeField]
    private List<AudioClip> SoundClips = new List<AudioClip>();

    private AudioSource myAudioSource = null;

    private void Awake()
    {
        myAudioSource = GetComponent<AudioSource>();

        if (myAudioSource == null)
        {
            Debug.LogError("Sound Player on object without an Audio Source");
        }

    }

    public void PlaySoundClip(int clipNumber = 0, float volume = 1f)
    {
        myAudioSource.Stop();
        myAudioSource.volume = volume;
        myAudioSource.PlayOneShot(SoundClips[clipNumber]);
    }

    public void PlaySoundClipContinuous(int clipNumber = 0, float volume = 1f)
    {
        myAudioSource.Stop();
        myAudioSource.volume = volume;
        myAudioSource.clip = SoundClips[clipNumber];
        myAudioSource.Play();
    }


}
