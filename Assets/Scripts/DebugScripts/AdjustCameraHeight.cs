using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdjustCameraHeight : MonoBehaviour
{
    [SerializeField]
    private Text CameraHeight = null;

    [SerializeField]
    private ToggleButton UpButton = null;

    [SerializeField]
    private ToggleButton DownButton = null;

    [SerializeField]
    private Transform Player = null;

    private void Update()
    {
        if (UpButton.GetLookStatus())
        {
            IncreaseCameraHeight();
        }
        else if (DownButton.GetLookStatus())
        {
            DecreaseCameraHeight();
        }
    }

    public void IncreaseCameraHeight()
    {
        Player.transform.Translate(Vector3.up * Time.deltaTime * .5f);
    }

    public void DecreaseCameraHeight()
    {
        Player.transform.Translate(Vector3.down * Time.deltaTime * .5f);
    }
}
