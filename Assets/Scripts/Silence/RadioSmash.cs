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

    [SerializeField] private Rigidbody throwObject = null;

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

        throwObject.useGravity = true;
        throwObject.isKinematic = false;

        throwObject.AddForce(Vector3.back * 5, ForceMode.Impulse);
        throwObject.AddTorque(Vector3.back * 20, ForceMode.Impulse);
    }

}
