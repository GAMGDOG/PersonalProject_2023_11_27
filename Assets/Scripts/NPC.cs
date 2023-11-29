using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{
    public Text DialogText;
    public GameObject panel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        panel.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        panel.SetActive(false);
    }
    public void OnClick()
    {
        GameObject button = GameObject.FindWithTag("DialogButton");
        if (button == null) return;
        button.SetActive(false);

        DialogText.text = "여기가 어디죠?";
    }
}
