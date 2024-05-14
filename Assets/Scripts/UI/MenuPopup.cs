using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPopup : MonoBehaviour
{
    public GameObject menu;

    public void OnPanel(GameObject menu)
    {
        menu.SetActive(true);
    }

    public void OffPanel(GameObject menu)
    {
        menu.SetActive(false);
    }
}
