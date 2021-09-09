using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shaker : MonoBehaviour
{
    //これがアタッチされたオブジェクトが揺れます。
    public float Timer1;
    public float Timer2;
    public float Timer3;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("shake");



    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator shake()
    {
        yield return new WaitForSeconds(Timer1);
        iTween.ShakePosition(this.gameObject, iTween.Hash("x", 2.3f, "y", 2.0f, "z", 2.0f, "time", 3.0f));
        yield return new WaitForSeconds(Timer2);
        iTween.ShakePosition(this.gameObject, iTween.Hash("x", 2.3f, "y", 2.0f, "z", 2.0f, "time", 3.0f));
        yield return new WaitForSeconds(Timer3);
        iTween.ShakePosition(this.gameObject, iTween.Hash("x", 2.3f, "y", 2.0f, "z", 2.0f, "time", 3.0f));

    }


}
