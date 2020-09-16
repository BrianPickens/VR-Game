using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioSmash : MonoBehaviour
{
    [SerializeField]
    private SkinnedMeshRenderer antenna = null;

    [SerializeField]
    private SkinnedMeshRenderer body = null;

    [SerializeField]
    private SkinnedMeshRenderer handle = null;

    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Alpha1))
    //    {
    //        BreakRadio();
    //    }
    //}

    public void BreakRadio()
    {
        antenna.SetBlendShapeWeight(0, 100f);
        body.SetBlendShapeWeight(0, 0f);
        handle.SetBlendShapeWeight(0, 100f);
    }
}
