using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockRemove : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidbody = null;

    public void TossLock()
    {
        myRigidbody.isKinematic = false;
        myRigidbody.useGravity = true;

        myRigidbody.AddForce(Vector3.forward * 1f, ForceMode.Impulse);
        myRigidbody.AddTorque(Vector3.back * 2f, ForceMode.Impulse);
    }
}
