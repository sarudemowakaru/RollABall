using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataType : MonoBehaviour

{  //int:　整数
    long integerNumber;
    //float: 少数(小数点以下第7位まで)
    float floatNumber;
    //double: 小数(小数点以下第15位まで)
    double doubleNumber;
    //char: 文字(1文字)
    char character;
    //string: 文字列
    string stringData;
    
    // Start is called before the first frame update
    void Start()
    {
        integerNumber = 100000000000;
        Debug.Log(integerNumber);
        floatNumber = 1.5f;
        Debug.Log(floatNumber);
        doubleNumber = 1.234567890123;
        Debug.Log(doubleNumber);
        character = 'u';
        Debug.Log(character);
        stringData = "unity";
        Debug.Log(stringData);

        //演習1
        Debug.Log("C:Users\\Username\\Documents");

        //演習2
        float number1 = 12.34f;
        int number2;
        number2 = (int)number1;
        Debug.Log(number2);
    }

}
