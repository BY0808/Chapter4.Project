using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ĳ���Ͱ� ���� �����̴� Ŭ����
public class CharacterMovement : MonoBehaviour
{
    //������ ������Ʈ ����
    private InputController movementController;
    private Rigidbody2D movementRigidbody;

    private Vector2 movementDirection = Vector2.zero;

    private void Awake()
    {
        //���� ������Ʈ�� �Է°���, ������ ��������
        movementController = GetComponent<InputController>();
        movementRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        //InputController�� OnMoveEvent �̺�Ʈ�� Move �޼ҵ� ����
        movementController.OnMoveEvent += Move;
    }

    private void Move(Vector2 direction)
    {
        //�Էµ� ���Ⱚ�� movementDirection �� �־���
        movementDirection = direction;
    }

    //���� �������� FixedUpdate���� ����
    private void FixedUpdate()
    {
        //�Է¹��� ����(������)�� ���� ����
        ApplyMovement(movementDirection);
    }

    //�Է¹��� ������ �����̰� �ϴ� �޼ҵ�
    private void ApplyMovement(Vector2 direction)
    {
        //���⿡ ���� ����
        direction = direction * 5;

        //�Է¹��� �������� �����̰� ��
        movementRigidbody.velocity = direction;
    }
}
