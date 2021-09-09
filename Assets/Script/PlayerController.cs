using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 20.0F;       //歩行速度
    public float gravity = 10.0F;    //重力の大きさ

    private CharacterController controller;
    private Vector3 moveDirection = Vector3.zero;
    public float h, v;
    // Use this for initialization
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    void Update()
    {
        h = Input.GetAxis("Horizontal");    //左右矢印キーの値(-1.0~1.0)
        v = Input.GetAxis("Vertical");      //上下矢印キーの値(-1.0~1.0)

        if (controller.isGrounded)
        {
            moveDirection = new Vector3(h, 0, v);
            moveDirection.Normalize();
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
        }
        controller.Move(moveDirection * Time.deltaTime);
        moveDirection.y -= gravity * Time.deltaTime;
    }
}
