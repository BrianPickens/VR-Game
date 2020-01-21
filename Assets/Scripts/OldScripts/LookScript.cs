using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookScript : MonoBehaviour
{

    [SerializeField]
    GameObject lastObject = null;

    private void Update()
    {
        CheckForGazeTarget();
    }

    //Check to see if we are looking at anything interactive
    private void CheckForGazeTarget()
    {
        RaycastHit hitInfo;
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hitInfo, 100.0f, 1 << 8))
        {
            Debug.Log("Hit Name: " + hitInfo.transform.gameObject.name);
            if (hitInfo.transform.gameObject.CompareTag("LookTarget"))
            {
                lastObject = hitInfo.transform.gameObject;
                //  hitInfo.transform.gameObject.
            }
        }
    }
}
