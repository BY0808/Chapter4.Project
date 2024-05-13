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
    //½Ì±ÛÅæÈ­!
    public static SelectPlayer instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null) return;
        //¾À ÀüÈ¯½Ã ¿ÀºêÁ§Æ® ¹ÌÆÄ±«
        DontDestroyOnLoad(gameObject);
    }

    public Character currentCharacter;
}
