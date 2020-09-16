using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorGlass : MonoBehaviour
{
    [SerializeField]
    private List<Rigidbody> glassShards = new List<Rigidbody>();

    [SerializeField]
    private GameObject unbrokenGlass = null;

    [SerializeField]
    private GameObject brokenGlass = null;

    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Alpha1))
    //    {
    //        BreakGlass();
    //    }
    //}

    public void BreakGlass()
    {
        unbrokenGlass.SetActive(false);
        brokenGlass.SetActive(true);
        for (int i = 0; i < glassShards.Count; i++)
        {
            glassShards[i].useGravity = true;
            glassShards[i].AddForce(Vector3.right * Random.Range(2,6),ForceMode.Impulse);
            if (i % 2 == 0)
            {
                glassShards[i].AddTorque(Vector3.forward * Random.Range(2, 10), ForceMode.Impulse);
            }
            else
            {
                glassShards[i].AddTorque(Vector3.left * Random.Range(2, 10), ForceMode.Impulse);
            }
            glassShards[i].transform.parent = null;
        }
    }
}
