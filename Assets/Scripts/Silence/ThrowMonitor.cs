using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowMonitor : MonoBehaviour
{

    [SerializeField]
    private Rigidbody throwObject = null;

    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Alpha1))
    //    {
    //        ThrowObject();       
    //    }
    //}

    public void ThrowObject()
    {
        throwObject.useGravity = true;
        throwObject.isKinematic = false;
        throwObject.AddForce(Vector3.forward * 4, ForceMode.Impulse);
        throwObject.AddForce(Vector3.right * 3, ForceMode.Impulse);
        throwObject.AddForce(Vector3.up * 4, ForceMode.Impulse);
        throwObject.AddTorque(Vector3.forward * 4, ForceMode.Impulse);
    }

}
