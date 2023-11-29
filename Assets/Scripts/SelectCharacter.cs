using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SelectCharacter : MonoBehaviour
{
    public Character character;
    public GameObject selectCharacter;
    void Start()
    {

    }

    public void OnClick()
    {
        ChangeCharacter();
        selectCharacter.SetActive(false);
    }

    public void ChangeCharacter()
    {
        DataManager.instance.currentCharacter = character;
    }
}
