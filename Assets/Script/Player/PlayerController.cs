using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody rb;

    Vector3 speed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        speed = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.W))
        {
            speed = new Vector3(speed.x, 0, speed.z + 7);
        }
        if (Input.GetKey(KeyCode.S))
        {
            speed = new Vector3(speed.x, 0, speed.z - 7);
        }
        if (Input.GetKey(KeyCode.A))
        {
            speed = new Vector3(speed.x - 7, 0, speed.z);
        }
        if (Input.GetKey(KeyCode.D))
        {
            speed = new Vector3(speed.x + 7, 0, speed.z);
        }

        rb.velocity = speed;
    }
}
