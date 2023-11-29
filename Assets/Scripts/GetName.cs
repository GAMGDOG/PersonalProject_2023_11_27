using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetName : MonoBehaviour
{
    public Text nameText;
    void Start()
    {
        LoadName();
    }

    // Update is called once per frame
    void Update()
    {
        LoadName();
    }

    void LoadName()
    {
        nameText.text = PlayerPrefs.GetString("name");
    }
}
