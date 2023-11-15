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
        // 新しいInput Systemを使用して"W"キーの入力を検知
        if (Keyboard.current.wKey.isPressed)
        {
            ballRigidBody.AddForce(Vector3.forward);
        }
        //Wキーが押され続けている間
        if (Keyboard.current.aKey.isPressed)
        {
            ballRigidBody.AddForce(Vector3.left);
        }
        // Wキーが離された瞬間だけ評価する
        if (Keyboard.current.sKey.isPressed)
        {
            ballRigidBody.AddForce(Vector3.back);
        }
        if (Keyboard.current.dKey.isPressed)
        {
            ballRigidBody.AddForce(Vector3.right);
        }

        Vector2 mousePosition = Mouse.current.position.ReadValue();
        Debug.Log($"マウスの座標: {mousePosition}");

        //演習
        if (Keyboard.current.wKey.isPressed)
        {
            Debug.Log("Wキーが押され続けてます！");
        }
        if (Keyboard.current.aKey.isPressed)
        {
            Debug.Log("Aキーが押され続けてます！");
        }
        if (Keyboard.current.sKey.isPressed)
        {
            Debug.Log("Sキーが押され続けてます！");
        }
        if (Keyboard.current.dKey.isPressed)
        {
            Debug.Log("Dキーが押され続けてます！");
        }
    }
    }
