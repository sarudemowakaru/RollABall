using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int n = 10; //�C�ӂ�n
        while(n > 0)
        {
            if(n % 2 == 0)//n�������̏ꍇ
            {
                n /= 2;
            }
            else �@//n����̏ꍇ
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
        /* while(����): ������true�ł���ꍇ�A�������J��Ԃ�
 */
        Debug.Log("while���[�v��1�`100�܂Ő����܂�");
        int counter = 1;
       while (counter <= 100)
        {
            Debug.Log(counter);
            counter += 1;
        }
        Debug.Log("while���[�v���I�����܂�");

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
                Debug.Log("�ړI�n�ɓ������܂����I");
                gameObject.SetActive(false);

            }

        } while (distance > 0);
    }
}
