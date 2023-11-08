using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int n = 10; //任意のn
        while(n > 0)
        {
            if(n % 2 == 0)//nが偶数の場合
            {
                n /= 2;
            }
            else 　//nが奇数の場合
            {
                n -= 1;
            }
            Debug.Log(n);//5,4,2,1,0
        }
        // ForLoop();
        //ForeachLoop();
        WhileLoop();
    }
    void WhileLoop()
    {
        /* while(条件): 条件がtrueである場合、処理を繰り返す
 */
        Debug.Log("whileループで1～100まで数えます");
        int counter = 1;
       while (counter <= 100)
        {
            Debug.Log(counter);
            counter += 1;
        }
        Debug.Log("whileループを終了します");

    }

    private int distance = 10;

    // Update is called once per frame
    void Update()
    {
        do
        {
            distance -= 1;
            Debug.Log(distance);

            if (distance == 0)
            {
                Debug.Log("目的地に到着しました！");
                gameObject.SetActive(false);

            }

        } while (distance > 0);
    }
}
