using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//컴포넌트를 가져오는 클래스
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
