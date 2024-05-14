using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterNameView : MonoBehaviour
{
    //������ �̸�
    public TextMeshProUGUI playerNameText;

    private GameObject nameChange;

    public void Awake()
    {
        //�Է��� �̸� ����
        string playerName = PlayerPrefs.GetString("PlayerName");
        playerNameText.text = playerName;
    }
}
