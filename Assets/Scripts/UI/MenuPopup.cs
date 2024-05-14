using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPopup : MonoBehaviour
{
    public GameObject menu;

    public void OnPanel(GameObject menu)
    {
        Time.timeScale = 0.0f;
        menu.SetActive(true);
    }

    public void OffPanel(GameObject menu)
    {
        Time.timeScale = 1.0f;
        menu.SetActive(false);
    }
}
