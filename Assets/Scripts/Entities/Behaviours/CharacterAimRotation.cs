using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//���콺 ���⿡ ���� ĳ���Ͱ� ������, ���� �ٶ󺸴� Ŭ����
public class CharacterAimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterRenderer;

    //��Ʈ�ѷ� ��������
    private InputController inputController;

    private void Awake()
    {
        //��Ʈ�ѷ� ȣ��
        inputController = GetComponent<InputController>();
    }

    private void Start()
    {
        //��Ʈ�ѷ��� OnAim �޼ҵ� ����
        inputController.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 direction)
    {
        //���⿡ ���� RotateObject ȣ��
        RotateObject(direction);
    }

    private void RotateObject(Vector2 direction)
    {
        //Z������ ȸ��
        float rotZ = Mathf.Atan2(direction.y, direction.x)*Mathf.Rad2Deg;

        //���밪 90�� ���� ĳ���� ������
        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }
}
