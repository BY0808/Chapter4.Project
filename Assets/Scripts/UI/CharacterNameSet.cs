using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterNameSet : MonoBehaviour
{
    public TMP_InputField inputName;
    public string playerName;

    public void StartGame()
    {
        //입력된 텍스트를 플레이어 이름에 넣어줌
        playerName = inputName.text;

        if (!string.IsNullOrEmpty(playerName))
        {
            //플레이어 이름 저장
            PlayerPrefs.SetString("PlayerName", playerName);
            DontDestroyOnLoad(gameObject);

            //게임시작
            SceneManager.LoadScene("MainScene");
        }
        else
        {
            Debug.Log("캐릭터명을 입력하세요.");
        }
    }
}
