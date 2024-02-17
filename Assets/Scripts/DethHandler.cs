using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DethHandler : MonoBehaviour
{
    [SerializeField] Canvas gameOverCanvas;

    public void Start()
    {
        gameOverCanvas.enabled = false;
    }

    public void HanldeDeath()
    {
        gameOverCanvas.enabled = true;
        Time.timeScale = 0;
        FindObjectOfType<WeaponSwitcher>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
