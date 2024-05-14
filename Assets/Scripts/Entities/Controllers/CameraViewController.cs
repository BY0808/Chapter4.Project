using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraViewController : MonoBehaviour
{
    //ī�޶� ����ٴ� Ÿ��
    public GameObject Target;

    //������ ī�޶� �ҷ�����
    private Camera cameraView;

    private Vector2 movementDirection = Vector2.zero;

    private void Awake()
    {
        cameraView = GetComponent<Camera>();
    }

    private void FixedUpdate()
    {
        ViewMovement();
    }

    private void ViewMovement()
    {
        //Ÿ�� ��ġ ���
        Vector3 moveDirection = new Vector3(Target.transform.position.x, Target.transform.position.y, cameraView.transform.position.z);
        //Ÿ�� ��ġ�� ī�޶� ��ġ�� �־���
        cameraView.transform.position = moveDirection;
    }

    public void SetTarget(GameObject target)
    {
        Target = target;
    }
}
