using UnityEngine;
using UnityEngine.InputSystem;

//�÷��̾��� �������� �Է¹޴� Ŭ����
public class PlayerInputController : InputController
{
    private Camera camera;
    
    //ī�޶� ȣ��, ����ī�޶� �Ҵ�
    public void Awake()
    {
        camera = Camera.main;
    }

    //�Է¹��� Ű(Ű����)�� ����ȭ��
    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        //InputController �� ��ӹ޾�, ��밡��
        CallMoveEvent(moveInput);
    }

    //�Է¹��� Ű(���콺)�� ����ȭ��
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
