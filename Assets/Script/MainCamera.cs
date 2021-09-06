using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    //MainCameraにスクリプト入れる
    private GameObject player;
    private float pos1;
    private float pos2;
    public float a;
    public float b;
    public float c;
    public float d;
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
        if(pos1 > a && pos2 > b)
        {
            this.gameObject.transform.position = new Vector3(c,y,d);
        }
    }
}