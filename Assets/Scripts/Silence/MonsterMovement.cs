using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovement : MonoBehaviour
{

    [SerializeField] private SkinnedMeshRenderer monsterBody = null;

    [SerializeField] private float monsterBreathSpeed = 10f;

    void Update()
    {
        monsterBody.SetBlendShapeWeight(0, Mathf.PingPong(Time.time * monsterBreathSpeed, 100f));
    }
}
