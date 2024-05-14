using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using TMPro;
using UnityEngine;

public class CurrentTime : MonoBehaviour
{
    private string currentTime;

    private TextMeshProUGUI setText;

    private void Awake()
    {
        setText = GetComponent<TextMeshProUGUI>();
    }

    public void GetCurrentDate()
    {
        currentTime =  DateTime.Now.ToString("HH:mm");
    }

    private void Update()
    {
        GetCurrentDate();
        SetTime(currentTime);
    }

    private void SetTime(string currentTime)
    {
        setText.text = currentTime;
    }
}
