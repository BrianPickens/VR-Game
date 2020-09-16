using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterFade : MonoBehaviour
{

    [SerializeField] private Material monsterMaterial = null;

    private float changeSpeed = 1f;

    private float targetAlpha = 0f;

    private void Update()
    {
        if (Mathf.Abs(monsterMaterial.color.a - targetAlpha) > Mathf.Epsilon)
        {
            Color newColor = monsterMaterial.color;
            newColor.a = Mathf.MoveTowards(newColor.a, targetAlpha, Time.deltaTime * changeSpeed);
            monsterMaterial.color = newColor;
        }
    }

    public void SetAlphaTarget(float _alphaTarget, float _changeSpeed)
    {
        targetAlpha = _alphaTarget;
        changeSpeed = _changeSpeed;
    }

}
