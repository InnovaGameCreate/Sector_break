using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class roomSelectButton : MonoBehaviour
{
    //MainPanelにある部屋のButtonにつけていく
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
        Debug.Log("クリック検知");
        door.selectRoom(newname.ToString());
        
    }
}
