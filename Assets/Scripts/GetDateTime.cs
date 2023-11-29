using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetDateTime : MonoBehaviour
{
    public Text time;
   void Update()
    {
        string timeText = DateTime.Now.ToString(("HH:mm"));
        time.text = timeText;
    }
}
