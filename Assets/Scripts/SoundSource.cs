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

    private void Awake()
    {
        myTransform = GetComponent<Transform>();
        myAudioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        targetTransform = myTransform;
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

    public void PlayAudio()
    {
        myAudioSource.Play();
    }

}
