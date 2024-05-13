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
        anim = GetComponentInChildren<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    //���콺 ��ư�� �����ٰ� ������ ���� ȣ�� �޼ҵ�
    private void OnMouseUpAsButton()
    {
        PlayerData.instance.currentCharacter = character;
        OnSelect();
        
        for (int i = 0; i < selectPlayers.Length; i++)
        {
            if (selectPlayers[i] != this)
            {
                selectPlayers[i].OnDeselect();
            }
        }
    }

    private void SelectResult()
    {
        //������ ĳ���͸� PlayerData�� ����
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
