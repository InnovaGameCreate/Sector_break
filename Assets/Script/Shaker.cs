using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shaker : MonoBehaviour
{
    //���ꂪ�A�^�b�`���ꂽ�I�u�W�F�N�g���h��܂��B

    
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
        Debug.Log("�h��Ă���悤��");
        iTween.ShakePosition(this.gameObject, iTween.Hash("x", 2.3f, "y", 2.0f, "z", 2.0f, "time", 4.0f));
        yield return new WaitForSeconds(150f);
        iTween.ShakePosition(this.gameObject, iTween.Hash("x", 2.3f, "y", 2.0f, "z", 2.0f, "time", 4.0f));
        yield return new WaitForSeconds(150f);
        iTween.ShakePosition(this.gameObject, iTween.Hash("x", 2.3f, "y", 2.0f, "z", 2.0f, "time", 4.0f));

    }


}
