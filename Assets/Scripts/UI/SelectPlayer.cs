using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPlayer : MonoBehaviour
{
    public CharacterList character;
    Animator anim;
    SpriteRenderer spriteRenderer;
    public SelectPlayer[] selectPlayers;

    private void Awake()
    {
        anim = GetComponent<SpriteRenderer>().GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    //마우스 버튼을 눌렀다가 떼었을 때만 호출 메소드
    private void OnMouseUpAsButton()
    {
        SelectResult();
        OnSelect("isWalking");
    }

    private void SelectResult()
    {
        //선택한 캐릭터를 PlayerData에 저장
        PlayerData.instance.currentCharacter = character;
    }

    private void OnSelect(string boolName)
    {
        anim.SetBool(boolName, true);
        spriteRenderer.color = new Color(1f,1f, 1f);
    }
}
