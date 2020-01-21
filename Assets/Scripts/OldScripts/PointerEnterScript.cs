using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerEnterScript : MonoBehaviour
{
    public void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
    {
        Debug.Log("this worked");
    }

    public void Doodle()
    {
        Debug.Log("THIS HAPPEBNE");
    }
}
