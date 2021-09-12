using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_identify : MonoBehaviour
{
    public bool O2 = true;
    public bool Storage = true;
    public bool Engine = true;
    public bool Coffee = true;
    public bool Living = true;

    [SerializeField] GameObject door_O2tank;

    [SerializeField] GameObject door_Strage;

    [SerializeField] GameObject door_Engineroom;

    [SerializeField] GameObject door_Coffeeroom;

    [SerializeField] GameObject door_Livingroom;

    [SerializeField] GameObject O2tank;

    [SerializeField] GameObject Strage;

    [SerializeField] GameObject Engineroom;

    [SerializeField] GameObject Coffeeroom;

    [SerializeField] GameObject Livingroom;

    public void OnClick(int number)
    {
        switch (number)
        {
            case 0:

                if (O2 == true) 
                {
                    Debug.Log("O2roomを封鎖しますか？");
                }
                break;
            case 1:
                if (Storage == true)
                {
                    Debug.Log("ストレージルームを封鎖しますか？");
                }
                break;
            case 2:
                if (Engine == true)
                {
                    Debug.Log("エンジンルームを封鎖しますか？");
                }
                break;
            case 3:
                if (Coffee == true)
                {
                    Debug.Log("コーヒールームを封鎖しますか？");
                }
                break;
            case 4:
                if (Living == true)
                {
                    Debug.Log("リビングルームを封鎖しますか？");
                }
                break;
            default:
                break;
        }//区画の各ボタンにそれぞれ０～４の異なる引数を渡してください。
    }
        
    }

