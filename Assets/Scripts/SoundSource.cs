using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
public class SoundSource : MonoBehaviour
{
    [SerializeField] private Transform myTransform = null;
    [SerializeField] private AudioSource myAudioSource = null;
    [SerializeField] private float targetVolume = 1f;
    private Transform targetTransform = null;
    private float moveSpeed = 1f;

    private float volumeChangeSpeed = 1f;

    private float targetPitch = 1f;
    private float pitchChangeSpeed = 1f;

    private float targetMinDistance = 1f;
    private float minDistanceChangeSpeed = 1f;

    private void Awake()
    {
        myTransform = GetComponent<Transform>();
        myAudioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        targetTransform = myTransform;
        targetPitch = myAudioSource.pitch;
        targetVolume = myAudioSource.volume;
        targetMinDistance = myAudioSource.minDistance;
    }

    private void Update()
    {
        if (Mathf.Abs(Vector3.Distance(myTransform.position, targetTransform.position)) > Mathf.Epsilon)
        {
            myTransform.position = Vector3.MoveTowards(myTransform.position, targetTransform.position, Time.deltaTime * moveSpeed);
        }

        if (Mathf.Abs(myAudioSource.volume - targetVolume) > Mathf.Epsilon)
        {
            myAudioSource.volume = Mathf.MoveTowards(myAudioSource.volume, targetVolume, Time.deltaTime * volumeChangeSpeed);
        }

        if (Mathf.Abs(myAudioSource.pitch - targetPitch) > Mathf.Epsilon)
        {
            myAudioSource.pitch = Mathf.MoveTowards(myAudioSource.pitch, targetPitch, Time.deltaTime * pitchChangeSpeed);
        }

        if (Mathf.Abs(myAudioSource.minDistance - targetMinDistance) > Mathf.Epsilon)
        {
            myAudioSource.minDistance = Mathf.MoveTowards(myAudioSource.minDistance, targetMinDistance, Time.deltaTime * minDistanceChangeSpeed);
        }

    }

    public void SetTargetTransform(Transform _target, float _moveSpeed)
    {
        targetTransform = _target;
        moveSpeed = _moveSpeed;
    }

    public void SetTargetVolume(float _targetVolume, float _changeSpeed)
    {
        targetVolume = _targetVolume;
        targetVolume = Mathf.Clamp01(targetVolume);
        volumeChangeSpeed = _changeSpeed;
    }

    public void ChangeVolumeByAmount(float _amount, float _changeSpeed)
    {
        targetVolume += _amount;
        targetVolume = Mathf.Clamp01(targetVolume);
        volumeChangeSpeed = _changeSpeed;
    }

    public void SetTargetPitch(float _targetPitch, float _changeSpeed)
    {
        targetPitch = _targetPitch;
        targetPitch = Mathf.Clamp(targetPitch, 0f, 3f);
        pitchChangeSpeed = _changeSpeed;
    }

    public void ChangePitchByAmount(float _amount, float _changeSpeed)
    {
        targetPitch += _amount;
        targetPitch = Mathf.Clamp(targetPitch, 0f, 3f);
        pitchChangeSpeed = _changeSpeed;
    }

    public void SetTargetMinDistance(float _targetMinDistance, float _changeSpeed)
    {
        targetMinDistance = _targetMinDistance;
        minDistanceChangeSpeed = _changeSpeed;
    }

    public void ChangeMinDistanceByAmount(float _amount, float _changeSpeed)
    {
        targetMinDistance += _amount;
        minDistanceChangeSpeed = _changeSpeed;
    }

    public void PlayAudio()
    {
        myAudioSource.Play();
    }

    public void PlayAudioWithDelay(float _delay)
    {
        Invoke("PlayAudio", _delay);
    }

    public void StopAudio()
    {
        myAudioSource.Stop();
    }

}
