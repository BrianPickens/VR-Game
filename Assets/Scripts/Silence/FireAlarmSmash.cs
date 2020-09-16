using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAlarmSmash : MonoBehaviour
{


    [SerializeField]
    private Rigidbody fireAlarm = null;

    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Alpha1))
    //    {
    //        BreakFireAlarm();
    //    }
    //}

    public void BreakFireAlarm()
    {
        fireAlarm.useGravity = true;
        fireAlarm.AddForce(Vector3.right * 3, ForceMode.Impulse);
        fireAlarm.AddForce(Vector3.forward * 1.5f, ForceMode.Impulse);
        fireAlarm.AddTorque(Vector3.left * 2, ForceMode.Impulse);
    }
}
