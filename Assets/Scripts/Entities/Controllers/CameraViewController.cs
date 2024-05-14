using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraViewController : MonoBehaviour
{
    //카메라가 따라다닐 타겟
    public GameObject Target;

    //연결할 카메라 불러오기
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
        //타겟 위치 계산
        Vector3 moveDirection = new Vector3(Target.transform.position.x, Target.transform.position.y, cameraView.transform.position.z);
        //타겟 위치를 카메라 위치에 넣어줌
        cameraView.transform.position = moveDirection;
    }

    public void SetTarget(GameObject target)
    {
        Target = target;
    }
}
