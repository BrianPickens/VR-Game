using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockGlass : MonoBehaviour
{

    [SerializeField]
    private Rigidbody clockHalf = null;

    [SerializeField]
    private Rigidbody clockFace = null;

    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Alpha1))
    //    {
    //        SplitClock();
    //    }
    //}

    public void SplitClock()
    {
        clockHalf.useGravity = true;
        clockFace.useGravity = true;
        clockHalf.AddForce(Vector3.right * 1.5f, ForceMode.Impulse);
        clockHalf.AddForce(Vector3.forward * 3, ForceMode.Impulse);
        clockHalf.AddForce(Vector3.down, ForceMode.Impulse);
        clockHalf.AddTorque(Vector3.right * 2, ForceMode.Impulse);
        clockFace.AddForce(Vector3.right * 3, ForceMode.Impulse);
        clockFace.AddForce(Vector3.down, ForceMode.Impulse);
        clockFace.AddTorque(Vector3.right * 2, ForceMode.Impulse);
    }
}
