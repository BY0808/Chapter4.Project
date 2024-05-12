using System;
using UnityEngine;

public class CharacterAnimationController : AnimationController
{
    private static readonly int isWalking = Animator.StringToHash("isWalking");

    //���Ͱ� ������ �̻� �����̴��� �Ǵ� �Ű�����
    private readonly float magnituteThreshold = 0.5f;

    protected override void Awake()
    {
        //��ӹ��� Ŭ������ Awake ȣ��
        base.Awake();
    }

    private void Start()
    {
        //Move �޼ҵ� �Է��̺�Ʈ�� ����
        controller.OnMoveEvent += Movement;
    }

    private void Movement(Vector2 vector)
    {
        //�Է°��� ������ġ���� ���� ���, IsWalking �� true�� ��ȯ
        animator.SetBool(isWalking, vector.magnitude > magnituteThreshold);
    }
}
