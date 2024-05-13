using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//마우스 방향에 따라 캐릭터가 오른쪽, 왼쪽 바라보는 클래스
public class CharacterAimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterRenderer;

    //컨트롤러 가져오기
    private InputController inputController;

    private void Awake()
    {
        //컨트롤러 호출
        inputController = GetComponent<InputController>();
    }

    private void Start()
    {
        //컨트롤러에 OnAim 메소드 연결
        inputController.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 direction)
    {
        //방향에 따라 RotateObject 호출
        RotateObject(direction);
    }

    private void RotateObject(Vector2 direction)
    {
        //Z축으로 회전
        float rotZ = Mathf.Atan2(direction.y, direction.x)*Mathf.Rad2Deg;

        //절대값 90도 기준 캐릭터 뒤집기
        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }
}
