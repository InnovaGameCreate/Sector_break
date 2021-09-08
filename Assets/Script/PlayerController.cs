using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rigidbody;

    [SerializeField]
    private float speed = 10.0f;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rigidbody.AddForce(new Vector3(speed * Time.deltaTime * -1, 0, 0));
        }

        if (Input.GetKey(KeyCode.D))
        {
            rigidbody.AddForce(new Vector3(speed * Time.deltaTime, 0, 0));
        }

        if (Input.GetKey(KeyCode.W))
        {
            rigidbody.AddForce(new Vector3(0, 0, speed * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.S))
        {
            rigidbody.AddForce(new Vector3(0, 0, speed * Time.deltaTime * -1));
        }
    }
}
