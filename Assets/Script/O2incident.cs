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
        if (gameSystem.isIncindent2 != true)//�����̏����̎d����������Ȃ��̂ŁA�����莟��C���B�ꉞ���̓f�o�b�N�̂�
        {
            Debug.Log("you dead");
        }
        else if (gameSystem.isIncindent2 == true)
        {
            Debug.Log("O2incident clear");
        }
    }
        //���parge�̃{�^������������Abool O2_parge�̒l��true�ɕύX����悤�ɂ���΂�����

   
}
