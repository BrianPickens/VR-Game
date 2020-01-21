using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrivacyPolicyScript : MonoBehaviour
{
    private bool lookedAt = false;

    [SerializeField]
    private Image fillImage = null;

    [SerializeField]
    private float fillSpeed = 1f;

    [SerializeField]
    private float openCooldown = 5f;

    private bool canOpen = true;

    private void Start()
    {
        canOpen = true;
    }

    private void Update()
    {
        if (lookedAt && canOpen)
        {
            fillImage.fillAmount = Mathf.MoveTowards(fillImage.fillAmount, 1f, Time.deltaTime * fillSpeed);
        }
        else
        {
            fillImage.fillAmount = Mathf.MoveTowards(fillImage.fillAmount, 0, Time.deltaTime * fillSpeed);
        }

        if (fillImage.fillAmount > 0.99f)
        {
            canOpen = false;
            fillImage.fillAmount = 0;
            Application.OpenURL("http://brianpickensgames.com/PrivacyPolicyItsInHere.html");
            StartCoroutine(OpenCooldown());
        }

    }

    public void LookedAt()
    {
        lookedAt = true;
    }

    public void NotLookedAt()
    {
        lookedAt = false;
    }

    private IEnumerator OpenCooldown()
    {
        yield return new WaitForSeconds(openCooldown);
        canOpen = true;
    }

}
