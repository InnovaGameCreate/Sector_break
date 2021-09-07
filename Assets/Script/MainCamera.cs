using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    //MainCameraにスクリプト入れる
    private GameObject player;
    private float pos1;
    private float pos2;
    public float a1;
    public float a2;
    public float b1;
    public float b2;
    public float c;
    public float d;
    public float e1;
    public float e2;
    public float f1;
    public float f2;
    public float g;
    public float h;
    public float y;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");



    }

    // Update is called once per frame
    void Update()
    {
        pos1 = player.transform.position.x;
        pos2 = player.transform.position.z;

        if (a1 <= pos1 && pos1 <= a2 && b1 <= pos2 && pos2 <= b2)
        {
            this.gameObject.transform.position = new Vector3(c, y, d);

        }
        if (e1 <= pos1 && pos1 <= e2 && f1 <= pos2 && pos2 <= f2)
        {
            this.gameObject.transform.position = new Vector3(g, y, h);
        }
    }
}
