using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSmash : MonoBehaviour
{

    [SerializeField]
    private Rigidbody door = null;

    [SerializeField]
    private Animator myAnimator = null;

    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Alpha2))
    //    {
    //        BreakDoor();
    //    }
    //}

    public void BreakDoor()
    {
        myAnimator.enabled = false;
        door.isKinematic = false;
        door.useGravity = true;
        door.AddForce(Vector3.right * 3, ForceMode.Impulse);
        door.AddTorque(Vector3.back * 8, ForceMode.Impulse);
    }
}

//x = -4.666
//y = 0
//z = -3.261