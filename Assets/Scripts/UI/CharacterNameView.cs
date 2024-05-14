using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterNameView : MonoBehaviour
{
    //이름이 따라다닐 타겟
    public Transform Target;

    //연결할 이름
    public TextMeshProUGUI playerNameText;

    public RectTransform nameTransform;
    private Vector2 movementDirection = Vector2.zero;

    private void Awake()
    {
        //입력한 이름 연결
        string playerName = PlayerPrefs.GetString("PlayerName");
        playerNameText.text = playerName;
        //playerNameText 위치 가져오기
        //nameTransform = playerNameText.GetComponent<RectTransform>();
    }

    /*
    private void FixedUpdate()
    {
        NameMovement();
    }
    private void NameMovement()
    {
        //타겟 위치 계산
        Vector3 targetPosition = new Vector3(Target.position.x, Target.position.y+1, Target.position.z);

        //타겟 위치를 스크린 포인트로 전환
        Vector3 targetDirection = Camera.main.WorldToScreenPoint(targetPosition);

        //타겟 위치를 이름 위치에 넣어줌
        playerNameText.rectTransform.position = targetDirection;
    }
    */
}
