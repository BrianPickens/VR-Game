using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookScript : MonoBehaviour
{

    [SerializeField]
    GameObject lastObject = null;

    private void Update()
    {
        RaycastHit hitInfo;
        if (Physics.Raycast(
                Camera.main.transform.position,
                Camera.main.transform.forward,
                out hitInfo,
                20.0f,
                Physics.DefaultRaycastLayers))
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
