using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdjustCameraHeight : MonoBehaviour
{
    [SerializeField]
    private Text CameraHeight = null;

    [SerializeField]
    private Text CameraHorizontal = null;

    [SerializeField]
    private ToggleButton LeftButton = null;

    [SerializeField]
    private ToggleButton RightButton = null;

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
        else if (RightButton.GetLookStatus())
        {
            MoveRight();
        }
        else if (LeftButton.GetLookStatus())
        {
            MoveLeft();
        }

        CameraHeight.text = Player.transform.position.y + "";

    }

    public void IncreaseCameraHeight()
    {
        Player.transform.Translate(Vector3.up * Time.deltaTime * .5f);
    }

    public void DecreaseCameraHeight()
    {
        Player.transform.Translate(Vector3.down * Time.deltaTime * .5f);
    }

    public void MoveRight()
    {
        Vector3 moveVector = new Vector3(0, 0, 1);
        Player.transform.Translate(moveVector * Time.deltaTime * .5f);
    }

    public void MoveLeft()
    {
        Vector3 moveVector = new Vector3(0, 0, -1);
        Player.transform.Translate(moveVector * Time.deltaTime * .5f);
    }
}
