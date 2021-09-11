using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_player : MonoBehaviour
{
    private float muki;
    void Start()
    {

    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            muki = 0;
        }
        if (Input.GetKey(KeyCode.A))
        {
            muki = 270;
        }
        if (Input.GetKey(KeyCode.S))
        {
            muki = 180;
        }
        if (Input.GetKey(KeyCode.D))
        {
            muki = 90;
        }
        transform.rotation = Quaternion.Euler(new Vector3(0, muki, 0));
    }
}