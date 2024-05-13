using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPlayer : MonoBehaviour
{
    public CharacterList character;
    Animator anim;
    SpriteRenderer spriteRenderer;

    private void Awake()
    {
        anim = GetComponentInChildren<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    //마우스 버튼을 눌렀다가 떼었을 때만 호출 메소드
    private void OnMouseDown()
    {
        if (anim.GetBool("isWalking"))
        {
            OnDeselect();
        }
        else
        {
            SelectPlayer[] allPlayers = FindObjectsOfType<SelectPlayer>();
            foreach (SelectPlayer player in allPlayers)
            {
                if (player != this && player.anim.GetBool("isWalking"))
                {
                    player.OnDeselect();
                }
            }
            OnSelect();
        }
    }

    private void SelectResult()
    {
        //선택한 캐릭터를 PlayerData에 저장
        PlayerData.instance.currentCharacter = character;
    }

    private void OnSelect()
    {
        SelectResult();
        anim.SetBool("isWalking", true);
        spriteRenderer.color = new Color(1f,1f, 1f);
    }

    private void OnDeselect()
    {
        anim.SetBool("isWalking", false);
        spriteRenderer.color = new Color(0f, 0f, 0f);
    }
}
