using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shaker : MonoBehaviour
{
    //これがアタッチされたオブジェクトが揺れます。

    
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
        yield return new WaitForSeconds(150f);
        Debug.Log("揺れているようだ");
        iTween.ShakePosition(this.gameObject, iTween.Hash("x", 2.3f, "y", 2.0f, "z", 2.0f, "time", 4.0f));
        yield return new WaitForSeconds(150f);
        iTween.ShakePosition(this.gameObject, iTween.Hash("x", 2.3f, "y", 2.0f, "z", 2.0f, "time", 4.0f));
        yield return new WaitForSeconds(150f);
        iTween.ShakePosition(this.gameObject, iTween.Hash("x", 2.3f, "y", 2.0f, "z", 2.0f, "time", 4.0f));

    }


}
