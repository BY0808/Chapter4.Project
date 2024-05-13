using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public enum CharacterList
{
    Chef, Mushroom, Crab
}

public class PlayerData : MonoBehaviour
{
    //�̱���ȭ!
    public static PlayerData instance;

    public static PlayerData Instance => instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            //�� ��ȯ�� ������Ʈ ���ı�
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public CharacterList currentCharacter = CharacterList.Chef;
}
