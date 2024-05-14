using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterRespawn : MonoBehaviour
{
    public GameObject[] charPrefabs;
    public GameObject player;

    private void Awake()
    {
        player = Instantiate(charPrefabs[(int)PlayerData.instance.currentCharacter]);
        player.transform.position = transform.position;
    }
}
