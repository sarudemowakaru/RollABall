using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalOperator : MonoBehaviour
{
    bool condition1 = true;
    bool condition2 = false;

    int a = 10;
    int b = 4;

    bool isRaining = true;
    bool hasUmbrella = true;

    // Start is called before the first frame update
    void Start()
    {
        //CheckCondition();
        if (condition1 && condition2) // false
        {
            Debug.Log("����1�Ə���2��true�ł�");// false�̂��ߕ\������Ȃ�
        }
        if (condition1 || condition2) // true
        {
            Debug.Log("����1�܂��͏���2��true�ł�"); // true�̂��ߕ\�������
        }

        if(a >= 10 && a != 15 && b <= 5)
        {
            //�����𖞂�������
        }
    }

    // Update is called once per frame
    void Update()
    {
        // &&:�_���ρiAND�j
        Debug.Log(condition1 && condition2);
        // ||:�_���a�iOR�j
        Debug.Log(condition1 || condition2);
        // !:�ے�iNOT�j
        Debug.Log(!condition1);
        // ^:�r���I�_���a�iXOR�j
        Debug.Log(condition1 ^ condition2);

    }
}
