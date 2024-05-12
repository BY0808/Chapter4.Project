using System;
using UnityEngine;

public class CharacterAnimationController : AnimationController
{
    private static readonly int isWalking = Animator.StringToHash("isWalking");

    //벡터가 일정값 이상 움직이는지 판단 매개변수
    private readonly float magnituteThreshold = 0.5f;

    protected override void Awake()
    {
        //상속받은 클래스의 Awake 호출
        base.Awake();
    }

    private void Start()
    {
        //Move 메소드 입력이벤트에 연결
        controller.OnMoveEvent += Movement;
    }

    private void Movement(Vector2 vector)
    {
        //입력값이 설정수치보다 높을 경우, IsWalking 을 true로 반환
        animator.SetBool(isWalking, vector.magnitude > magnituteThreshold);
    }
}
