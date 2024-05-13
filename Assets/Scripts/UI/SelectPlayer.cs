using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPlayer : MonoBehaviour
{
    public CharacterList character;

    //마우스 버튼을 눌렀다가 떼었을 때만 호출 메소드
    private void OnMouseDown()
    {
        SelectResult();
    }

    private void SelectResult()
    {
        //선택한 캐릭터를 PlayerData에 저장
        PlayerData.instance.currentCharacter = character;
    }
}
