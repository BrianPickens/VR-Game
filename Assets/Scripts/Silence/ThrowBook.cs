using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBook : MonoBehaviour
{
    [SerializeField]
    private Rigidbody throwObject = null;

    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Alpha1))
    //    {
    //        ThrowBookObject();
    //    }
    //}

    public void ThrowBookObject()
    {
        throwObject.useGravity = true;
        throwObject.isKinematic = false;
        throwObject.AddForce(Vector3.left * 6, ForceMode.Impulse);
        throwObject.AddForce(Vector3.up * 1, ForceMode.Impulse);
        throwObject.AddTorque(Vector3.forward * 2, ForceMode.Impulse);
    }

}
