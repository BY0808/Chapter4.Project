using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//캐릭터가 실제 움직이는 클래스
public class CharacterMovement : MonoBehaviour
{
    //연결할 오브젝트 선언
    private InputController movementController;
    private Rigidbody2D movementRigidbody;

    private Vector2 movementDirection = Vector2.zero;

    private void Awake()
    {
        //같은 오브젝트의 입력값과, 물리값 가져오기
        movementController = GetComponent<InputController>();
        movementRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        //InputController의 OnMoveEvent 이벤트에 Move 메소드 연결
        movementController.OnMoveEvent += Move;
    }

    private void Move(Vector2 direction)
    {
        //입력된 방향값을 movementDirection 에 넣어줌
        movementDirection = direction;
    }

    //물리 설정값은 FixedUpdate에서 적용
    private void FixedUpdate()
    {
        //입력받은 방향(움직임)값 물리 적용
        ApplyMovement(movementDirection);
    }

    //입력받은 방향대로 움직이게 하는 메소드
    private void ApplyMovement(Vector2 direction)
    {
        //방향에 가속 설정
        direction = direction * 5;

        //입력받은 방향으로 움직이게 함
        movementRigidbody.velocity = direction;
    }
}
