using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioPitchChange : MonoBehaviour
{

    [SerializeField]
    private AudioSource radioAudio = null;

    [SerializeField]
    private GameObject radioLight = null;

    private float targetPitch = 1f;

    private float pitchChangeSpeed = 1f;

    private float targetVolume = 0.25f;

    private float volumeChangeSpeed = 1f;

    private float targetSpatialBlend = 0.75f;

    private float spatialBlendChangeSpeed = 1f;

    private void Update()
    {
        if (Mathf.Abs(radioAudio.pitch - targetPitch) > Mathf.Epsilon)
        {
            radioAudio.pitch = Mathf.MoveTowards(radioAudio.pitch, targetPitch, Time.deltaTime * pitchChangeSpeed);
        }

        if (Mathf.Abs(radioAudio.volume - targetVolume) > Mathf.Epsilon)
        {
            radioAudio.volume = Mathf.MoveTowards(radioAudio.volume, targetVolume, Time.deltaTime * volumeChangeSpeed);
        }

        if (Mathf.Abs(radioAudio.spatialBlend - targetSpatialBlend) > Mathf.Epsilon)
        {
            radioAudio.spatialBlend = Mathf.MoveTowards(radioAudio.spatialBlend, targetSpatialBlend, Time.deltaTime * spatialBlendChangeSpeed);
        }
    }

    public void ChangePitch(float _pitch, float _changeSpeed)
    {
        targetPitch = _pitch;
        pitchChangeSpeed = _changeSpeed;
    }

    public void ChangeVolume(float _volume, float _changeSpeed)
    {
        targetVolume = _volume;
        volumeChangeSpeed = _changeSpeed;
    }

    public void ChangeSpecialBlend(float _spatialBlend, float _changeSpeed)
    {
        targetSpatialBlend = _spatialBlend;
        spatialBlendChangeSpeed = _changeSpeed;
    }

    public void TurnOnRadioLight()
    {
        radioLight.SetActive(true);
    }

    public void TurnOffRadioLight()
    {
        radioLight.SetActive(false);
    }

    public void SetRadioLightIntensity(float _intensity)
    {
        radioLight.GetComponent<Light>().intensity = _intensity;
    }

}
