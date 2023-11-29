using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterChangeInGame : MonoBehaviour
{
    public Character character;
    public GameObject selectCharacter;
    public GameObject[] charPrefabs;
    public GameObject player;

    void Start()
    {

    }

    public void OnClick()
    {
        Vector2 targetPos = new Vector2(GameObject.FindGameObjectWithTag("Player").transform.position.x, GameObject.FindGameObjectWithTag("Player").transform.position.y);
        ChangeCharacter();
        selectCharacter.SetActive(false);
        Destroy(GameObject.FindGameObjectWithTag("Player"));
        player = Instantiate(charPrefabs[(int)DataManager.instance.currentCharacter]);
        player.transform.position = targetPos;
    }

    public void ChangeCharacter()
    {
        DataManager.instance.currentCharacter = character;
    }
}
