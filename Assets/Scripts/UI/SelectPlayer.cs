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

    //���콺 ��ư�� �����ٰ� ������ ���� ȣ�� �޼ҵ�
    private void OnMouseUpAsButton()
    {
        SelectResult();
        OnSelect("isWalking");
    }

    private void SelectResult()
    {
        //������ ĳ���͸� PlayerData�� ����
        PlayerData.instance.currentCharacter = character;
    }

    private void OnSelect(string boolName)
    {
        anim.SetBool(boolName, true);
        spriteRenderer.color = new Color(1f,1f, 1f);
    }
}
