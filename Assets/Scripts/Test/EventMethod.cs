using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventMethod : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Start���O�Ɉ�񂾂����s�����");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Awake���S�ď������ꂽ��Ɉ�񂾂����s�����");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("���t���[�����s�����B�������ACPU�̑��x�ɂ���ăt���[���͕ϓ����܂�");
    }

    private void FixedUpdate()
    {
        Debug.Log("��莞�ԊԊu���ƂɌĂяo�����B���������Ȃǂ𑀍삷�鎞�Ɏg���B");
    }
}
