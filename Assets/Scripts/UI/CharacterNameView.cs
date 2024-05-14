using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterNameView : MonoBehaviour
{
    //연결할 이름
    public TextMeshProUGUI playerNameText;

    private GameObject nameChange;

    public void Awake()
    {
        //입력한 이름 연결
        string playerName = PlayerPrefs.GetString("PlayerName");
        playerNameText.text = playerName;
    }
}
