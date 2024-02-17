using System;
using System.Collections;
using UnityEngine;

public class DisplayDamage : MonoBehaviour
{
    [SerializeField] Canvas damageCanvas;
    [SerializeField] float impactTime = 0.3f;

    private void Start()
    {
        damageCanvas.enabled = false;
    }
    public void ShowDamageCanvas()
    {
        StartCoroutine(ShowDamageInpact());
    }

    IEnumerator ShowDamageInpact()
    {
        damageCanvas.enabled = true;
        yield return new WaitForSeconds(impactTime);
        damageCanvas.enabled = false;
    }
}
