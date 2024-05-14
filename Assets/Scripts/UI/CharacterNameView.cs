using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterNameView : MonoBehaviour
{
    //�̸��� ����ٴ� Ÿ��
    public Transform Target;

    //������ �̸�
    public TextMeshProUGUI playerNameText;

    public RectTransform nameTransform;
    private Vector2 movementDirection = Vector2.zero;

    private void Awake()
    {
        //�Է��� �̸� ����
        string playerName = PlayerPrefs.GetString("PlayerName");
        playerNameText.text = playerName;
        //playerNameText ��ġ ��������
        //nameTransform = playerNameText.GetComponent<RectTransform>();
    }

    /*
    private void FixedUpdate()
    {
        NameMovement();
    }
    private void NameMovement()
    {
        //Ÿ�� ��ġ ���
        Vector3 targetPosition = new Vector3(Target.position.x, Target.position.y+1, Target.position.z);

        //Ÿ�� ��ġ�� ��ũ�� ����Ʈ�� ��ȯ
        Vector3 targetDirection = Camera.main.WorldToScreenPoint(targetPosition);

        //Ÿ�� ��ġ�� �̸� ��ġ�� �־���
        playerNameText.rectTransform.position = targetDirection;
    }
    */
}
