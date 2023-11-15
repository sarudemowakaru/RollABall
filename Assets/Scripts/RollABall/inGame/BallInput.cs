using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallInput : MonoBehaviour
{
    public GameObject Ball;
    private Rigidbody ballRigidBody;
    // Start is called before the first frame update
    private void Start()
    {
        ballRigidBody = Ball.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // �V����Input System���g�p����"W"�L�[�̓��͂����m
        if (Keyboard.current.wKey.isPressed)
        {
            ballRigidBody.AddForce(Vector3.forward);
        }
        //W�L�[�������ꑱ���Ă����
        if (Keyboard.current.aKey.isPressed)
        {
            ballRigidBody.AddForce(Vector3.left);
        }
        // W�L�[�������ꂽ�u�Ԃ����]������
        if (Keyboard.current.sKey.isPressed)
        {
            ballRigidBody.AddForce(Vector3.back);
        }
        if (Keyboard.current.dKey.isPressed)
        {
            ballRigidBody.AddForce(Vector3.right);
        }

        Vector2 mousePosition = Mouse.current.position.ReadValue();
        Debug.Log($"�}�E�X�̍��W: {mousePosition}");

        //���K
        if (Keyboard.current.wKey.isPressed)
        {
            Debug.Log("W�L�[�������ꑱ���Ă܂��I");
        }
        if (Keyboard.current.aKey.isPressed)
        {
            Debug.Log("A�L�[�������ꑱ���Ă܂��I");
        }
        if (Keyboard.current.sKey.isPressed)
        {
            Debug.Log("S�L�[�������ꑱ���Ă܂��I");
        }
        if (Keyboard.current.dKey.isPressed)
        {
            Debug.Log("D�L�[�������ꑱ���Ă܂��I");
        }
    }
    }
