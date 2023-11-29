using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameChangeInGame : MonoBehaviour
{
    public GameObject nameChange;
    public void onClick()
    {
        nameChange.SetActive(true);
    }
}
