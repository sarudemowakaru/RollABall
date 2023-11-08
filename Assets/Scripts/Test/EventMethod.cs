using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventMethod : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Startより前に一回だけ実行される");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Awakeが全て処理された後に一回だけ実行される");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("毎フレーム実行される。ただし、CPUの速度によってフレームは変動します");
    }

    private void FixedUpdate()
    {
        Debug.Log("一定時間間隔ごとに呼び出される。物理挙動などを操作する時に使う。");
    }
}
