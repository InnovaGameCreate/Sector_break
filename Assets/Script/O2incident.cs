using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class O2incident : MonoBehaviour
{
    
    DoorStop DoorstopScript;
    gameSystem gamesystem;

    // Start is called before the first frame update
    void Start()
    {
        //script = GameObject.Find("A").GetComponent<ClickYes>();
        gamesystem = GetComponent<gameSystem>();
        StartCoroutine("incident");
        

    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator incident()
    {
        yield return new WaitForSeconds(300f);
        if (gameSystem.isIncindent2 != true)//ここの処理の仕方が分からないので、分かり次第修正。一応今はデバックのみ
        {
            Debug.Log("you dead");
        }
        else if (gameSystem.isIncindent2 == true)
        {
            Debug.Log("O2incident clear");
        }
    }
        //後はpargeのボタンを押したら、bool O2_pargeの値をtrueに変更するようにすればいける

   
}
