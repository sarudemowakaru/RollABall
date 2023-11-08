﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComparisonOperator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*比較演算子
        True:真
        False:偽

        */
        int x = 8;
        int y = 7;
        Debug.Log(x == y); // false
        Debug.Log(x != y); // true
        Debug.Log(x > y); // false
        Debug.Log(x < y); // true
        Debug.Log(x >= y); // false
        Debug.Log(x <= y); // true
        Debug.Log(x > 5); // false
        Debug.Log(x >= 5); // true

        bool trueOrFalse = (x == y); //false
        if (trueOrFalse) // false
        {
            Debug.Log("xとyは等しいです"); // falseのため表示されない
        }
        trueOrFalse = (x != y);
        if (trueOrFalse) // true
        {
            Debug.Log("xとyは等しくないです"); // trueのため表示される
        }

        //①
      
        if (x > y)
        {
            Debug.Log("xはyより大きい");
        }

        //➁
        string name1 = "john";
        string name2 = "john";
        if(name1 == name2)
        {
            Debug.Log("2つの名前は同じです");
        }

        //③
        int age = 0;
        if (age >= 20)
        {
            Debug.Log("成人です");
        }
        else
        {
            Debug.Log("未成年です");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
