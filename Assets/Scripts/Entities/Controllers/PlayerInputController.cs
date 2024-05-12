using UnityEngine;
using UnityEngine.InputSystem;

//플레이어의 움직임을 입력받는 클래스
public class PlayerInputController : InputController
{
    private Camera camera;
    
    //카메라 호출, 메인카메라 할당
    public void Awake()
    {
        camera = Camera.main;
    }

    //입력받은 키(키보드)을 정규화함
    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        //InputController 를 상속받아, 사용가능
        CallMoveEvent(moveInput);
    }

    //입력받은 키(마우스)을 정규화함
    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = camera.ScreenToWorldPoint(newAim);
        newAim = (worldPos - (Vector2)transform.position).normalized;

        if (newAim.magnitude >= 0.9f)
        {
            CallLookEvent(newAim);
        }
    }
}
