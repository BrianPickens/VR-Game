using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desk3 : MonoBehaviour
{
    [SerializeField]
    private Rigidbody throwObject = null;

    [SerializeField]
    private BoxCollider collider = null;

    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Alpha4))
    //    {
    //        MoveDesk();
    //    }

    //}

    public void MoveDesk()
    {
        collider.enabled = true;

        throwObject.useGravity = true;
        throwObject.isKinematic = false;
        throwObject.AddTorque(Vector3.down * 1, ForceMode.Impulse);
        throwObject.AddForce(Vector3.right * 2.5f, ForceMode.Impulse);

        Invoke("RemoveCollision", 4f);

    }

    public void RemoveCollision()
    {
        throwObject.isKinematic = true;
        throwObject.useGravity = false;
        collider.enabled = false;
    }
}
