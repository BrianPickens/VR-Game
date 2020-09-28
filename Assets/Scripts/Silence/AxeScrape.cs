using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeScrape : MonoBehaviour
{
    [SerializeField] private Transform myTransform = null;

    [SerializeField] private AudioSource myAudioSource = null;

    [SerializeField] private AudioClip fastAxeMove = null;

    [SerializeField] private AudioClip slowAxeMove = null;

    private Transform targetTransform = null;

    private Vector3 referencePosition = Vector3.zero;

    private float moveSpeed = 1f;

    private float targetVolume = 0f;

    private float volumeChangeSpeed = 1f;

    private void Start()
    {
        targetTransform = myTransform;
    }

    private void Update()
    {
        if (Mathf.Abs(myTransform.position.x - targetTransform.position.x) > Mathf.Epsilon || Mathf.Abs(myTransform.position.z - targetTransform.position.z) > Mathf.Epsilon)
        {
            float x = Mathf.MoveTowards(myTransform.position.x, targetTransform.position.x, Time.deltaTime * moveSpeed);
            float z = Mathf.MoveTowards(myTransform.position.z, targetTransform.position.z, Time.deltaTime * moveSpeed);
            referencePosition.x = x;
            referencePosition.z = z;
            referencePosition.y = myTransform.position.y;
            myTransform.position = referencePosition;
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
        volumeChangeSpeed = _changeSpeed;
    }

    public void SetAxeToFast()
    {
        myAudioSource.clip = fastAxeMove;
        myAudioSource.Play();
    }

    public void SetAxeToSlow()
    {
        myAudioSource.clip = slowAxeMove;
        myAudioSource.Play();
    }

}
