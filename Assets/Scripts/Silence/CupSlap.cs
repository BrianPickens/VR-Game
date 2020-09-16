using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupSlap : MonoBehaviour
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
        transform.SetParent(null);
        throwObject.useGravity = true;
        throwObject.isKinematic = false;
        throwObject.AddForce(Vector3.left * Random.Range(1, 2), ForceMode.Impulse);
        throwObject.AddTorque(Vector3.forward * Random.Range(1, 2), ForceMode.Impulse);
    }

}
