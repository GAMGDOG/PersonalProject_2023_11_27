using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCharacter : MonoBehaviour
{
    public GameObject[] charPrefabs;
    public GameObject player;

    void Start()
    {
        player = Instantiate(charPrefabs[(int)DataManager.instance.currentCharacter]);
        player.transform.position = transform.position;
    }

    public void CharacterDestroy()
    {
        Destroy(player);
    }
}
