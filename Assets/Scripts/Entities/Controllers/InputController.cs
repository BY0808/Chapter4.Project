using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�������� �Է¹޴� Ŭ����
public class InputController : MonoBehaviour
{
    //�̺�Ʈ ����, ���� �޼��� ������ Action, Vector2 Ÿ�� �Ű�����
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;

    //�̵����� �Է� �޼ҵ�
    public void CallMoveEvent(Vector2 direction)
    {
        //�Էµ� direction ����, OnMoveEvent �̺�Ʈ ȣ��
        OnMoveEvent?.Invoke(direction);
    }

    //�� ���� �Է� �޼ҵ�
    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }

}
