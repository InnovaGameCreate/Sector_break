using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class roomSelectButton : MonoBehaviour
{
    //MainPanel�ɂ��镔����Button�ɂ��Ă���
    [SerializeField]
     DoorStop door;

    [SerializeField]
    private roomName newname;

    private enum roomName
    {
        O2,
        Storage,
        Engine,
        Coffee,
        Living,
    }
    

    public void OnClick()
    {
        door.selectRoom(newname.ToString());
    }
}
   

