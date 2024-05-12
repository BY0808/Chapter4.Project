using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//������Ʈ�� �������� Ŭ����
public class AnimationController : MonoBehaviour
{
    protected Animator animator;
    protected InputController controller;

    protected virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        controller = GetComponent<InputController>();
    }
}
