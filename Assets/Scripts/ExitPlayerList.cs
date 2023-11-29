using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitPlayerList : MonoBehaviour
{
    public GameObject playerList;

    public void OnclickExitButton()
    {
        playerList.SetActive(false);
    }

    public void OnclickListButton()
    {
        playerList.SetActive(true);
    }

}
