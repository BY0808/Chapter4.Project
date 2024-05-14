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
        //�Էµ� �ؽ�Ʈ�� �÷��̾� �̸��� �־���
        playerName = inputName.text;

        if (!string.IsNullOrEmpty(playerName))
        {
            //�÷��̾� �̸� ����
            PlayerPrefs.SetString("PlayerName", playerName);
            DontDestroyOnLoad(gameObject);

            //���ӽ���
            SceneManager.LoadScene("MainScene");
        }
        else
        {
            Debug.Log("ĳ���͸��� �Է��ϼ���.");
        }
    }
}
