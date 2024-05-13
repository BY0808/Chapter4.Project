using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;


public enum CharacterDic
{
    CHEF, MUSHROOM, CRAB
}

public class SelectPlayer : MonoBehaviour
{
    //�̱���ȭ!
    public static SelectPlayer instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null) return;
        //�� ��ȯ�� ������Ʈ ���ı�
        DontDestroyOnLoad(gameObject);
    }

    public Character currentCharacter;
}
