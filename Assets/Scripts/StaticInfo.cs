using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticInfo : MonoBehaviour
{

    private static StaticInfo instance = null;

    public static StaticInfo Instance
    {
        get { return instance; }
    }

    private bool skipIntro = false;
    public bool SkipIntro
    {
        get { return skipIntro; }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    public void SetSkipIntro(bool _skipIntro)
    {
        skipIntro = _skipIntro;
    }

}
