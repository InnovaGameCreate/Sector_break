using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_identify : MonoBehaviour
{

    public bool O2tank = false;
    [SerializeField]
    GameObject door_O2tank;

    [SerializeField]
    GameObject door_Strage;

    [SerializeField]
    GameObject door_Engineroom;

    [SerializeField]
    GameObject door_Coffeeroom;

    [SerializeField]
    GameObject door_Livingroom;
    public void OnClick(int number)
    {
        switch (number)
        {
            case 0:
              
                if (O2tank == true)
                {
                    Debug.Log("O2タンクを封鎖しますか？");
                }
                break;
            case 1:
                door_Strage.GetComponent<OpenDoor>().enabled = false;
                break;
            case 2:
                door_Engineroom.GetComponent<OpenDoor>().enabled = false;
                break;
            case 3:
                door_Coffeeroom.GetComponent<OpenDoor>().enabled = false;
                break;
            case 4:
                door_Livingroom.GetComponent<OpenDoor>().enabled = false;
                break;
            default:
                break;
        }//区画の各ボタンにそれぞれ０～４の異なる引数を渡してください。

    }
}
