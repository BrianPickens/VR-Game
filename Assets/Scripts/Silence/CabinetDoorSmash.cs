using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabinetDoorSmash : MonoBehaviour
{
    [SerializeField]
    private List<Rigidbody> doorShards = new List<Rigidbody>();

    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Alpha1))
    //    {
    //        BreakCabinet();
    //    }
    //}

    public void BreakCabinet()
    {
        for (int i = 0; i < doorShards.Count; i++)
        {
            doorShards[i].useGravity = true;
            doorShards[i].isKinematic = false;
            doorShards[i].AddForce(Vector3.right * Random.Range(1f, 2f), ForceMode.Impulse);

            doorShards[i].AddTorque(Vector3.back * Random.Range(1f, 2f), ForceMode.Impulse);

        }

        Invoke("TurnOffShards", 2f);

    }

    public void TurnOffShards()
    {
        for (int i = 0; i < doorShards.Count; i++)
        {
            doorShards[i].gameObject.SetActive(false);

        }
    }
}
