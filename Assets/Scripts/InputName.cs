using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InputName : MonoBehaviour
{
    public Text inputName;
    public Button button_join;
    public GameObject changeName;

    public void JoinButtonClick()
    {
        if (inputName.text.Length >= 2 && inputName.text.Length <= 10)
        {
            PlayerPrefs.SetString("name", inputName.text);
            SceneManager.LoadScene("MainScene");
        }
    }

    public void OnClick()
    {
        if(inputName.text.Length >= 2 && inputName.text.Length<=10)
        {
            PlayerPrefs.SetString("name", inputName.text);
            GameObject.FindGameObjectWithTag("PlayerName").GetComponent<Text>().text = inputName.text;
            changeName.SetActive(false);
        }
    }
}
