using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelectButton : MonoBehaviour
{
    public GameObject penguin;
    public GameObject knight;

    private void Update()
    {
        if (DataManager.instance.currentCharacter == Character.Penguin)
        {
            penguin.SetActive(true);
            knight.SetActive(false);
        }
        else
        {
            penguin.SetActive(false);
            knight.SetActive(true);
        }

    }
}
