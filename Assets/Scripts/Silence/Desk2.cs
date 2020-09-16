using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desk2 : MonoBehaviour
{
    [SerializeField]
    private Rigidbody throwObject = null;

    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Alpha2))
    //    {
    //        MoveDesk();
    //    }

    //    if (Input.GetKeyDown(KeyCode.Alpha3))
    //    {
    //        ThrowDesk();
    //    }
    //}

    public void MoveDesk()
    {
        throwObject.useGravity = true;
        throwObject.isKinematic = false;
        throwObject.AddTorque(Vector3.down * 1, ForceMode.Impulse);
        throwObject.AddForce(Vector3.right * 2.5f, ForceMode.Impulse);

    }

    public void ThrowDesk()
    {
        throwObject.AddForce(Vector3.left * 10, ForceMode.Impulse);
        throwObject.AddForce(Vector3.up * 8, ForceMode.Impulse);
        throwObject.AddForce(Vector3.back * 2, ForceMode.Impulse);
        throwObject.AddTorque(Vector3.forward * 20, ForceMode.Impulse);

    }
}
