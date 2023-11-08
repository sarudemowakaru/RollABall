using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DotNet : MonoBehaviour
{
    public Text DayText;
    public Text DayAddWeakText;
    // Start is called before the first frame update
    void Start()
    {

        DayText.text = DateTime.Now.ToString();
        DayAddWeakText.text = DateTime.Now.AddDays(7).ToString();

        ShowTime();
    }
    void ShowTime()
    {
        DateTime now = DateTime.Now; // ¡‚ÌŠÔ‚ğæ“¾‚·‚é
        Debug.Log(now); // ¡‚ÌŠÔ‚ğƒQ[ƒ€‚É•\¦‚·‚é
    }

}
