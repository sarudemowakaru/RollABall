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
        DateTime now = DateTime.Now; // 今の時間を取得する
        Debug.Log(now); // 今の時間をゲームに表示する
    }

}
