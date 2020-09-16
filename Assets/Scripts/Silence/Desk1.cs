using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desk1 : MonoBehaviour
{
    [SerializeField]
    private Rigidbody throwObject = null;

    [SerializeField]
    private BoxCollider collider = null;

    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Alpha2))
    //    {
    //        MoveDesk();
    //    }
    //}

    public void MoveDesk()
    {
        throwObject.useGravity = true;
        throwObject.isKinematic = false;
        throwObject.AddTorque(Vector3.up * 1, ForceMode.Impulse);
        throwObject.AddForce(Vector3.left * 2.5f, ForceMode.Impulse);

        Invoke("RemoveCollision", 4f);

    }

    public void ThrowDesk()
    {
        collider.enabled = true;
        throwObject.useGravity = true;
        throwObject.isKinematic = false;

        throwObject.AddForce(Vector3.right * 10, ForceMode.Impulse);
        throwObject.AddForce(Vector3.up * 8, ForceMode.Impulse);
        throwObject.AddForce(Vector3.back * 2, ForceMode.Impulse);
        throwObject.AddTorque(Vector3.forward * 20, ForceMode.Impulse);
    }

    public void RemoveCollision()
    {
        throwObject.isKinematic = true;
        throwObject.useGravity = false;
        collider.enabled = false;
    }
}
