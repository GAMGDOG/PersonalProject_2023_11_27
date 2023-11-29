using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacterChange : MonoBehaviour
{
    public GameObject characterSelect;
    public void OnClick()
    {
        characterSelect.SetActive(true);
    }
}
