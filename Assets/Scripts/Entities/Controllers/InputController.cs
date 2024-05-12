using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//움직임을 입력받는 클래스
public class InputController : MonoBehaviour
{
    //이벤트 정의, 실행 메서드 형식이 Action, Vector2 타입 매개변수
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;

    //이동방향 입력 메소드
    public void CallMoveEvent(Vector2 direction)
    {
        //입력된 direction 기준, OnMoveEvent 이벤트 호출
        OnMoveEvent?.Invoke(direction);
    }

    //볼 방향 입력 메소드
    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }

}
