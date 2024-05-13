using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterNameView : MonoBehaviour
{
    public TextMeshProUGUI playerNameText;


    void Start()
    {
        string playerName = PlayerPrefs.GetString("PlayerName");
        playerNameText.text = playerName;
    }
}
