using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPlayer : MonoBehaviour
{
    public CharacterList character;

    //���콺 ��ư�� �����ٰ� ������ ���� ȣ�� �޼ҵ�
    private void OnMouseDown()
    {
        SelectResult();
    }

    private void SelectResult()
    {
        //������ ĳ���͸� PlayerData�� ����
        PlayerData.instance.currentCharacter = character;
    }
}
