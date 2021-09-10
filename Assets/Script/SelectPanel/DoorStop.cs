using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorStop : MonoBehaviour
{
    //O2incidentのクリア条件用のbool
    bool O2_pargeClear = false;
    
    [SerializeField]
    GameObject door_O2tank;

    [SerializeField]
    GameObject door_Storage;

    [SerializeField]
    GameObject door_Engineroom;

    [SerializeField]
    GameObject door_Coffeeroom;

    [SerializeField]
    GameObject door_Livingroom;

    Button_identify script;

    OpenDoor DoorScript;
    // Start is called before the first frame update
    void Start()
    {
          script = GameObject.Find("MainPanel").GetComponent<Button_identify>();
          
    }
    //他の場所から選択している部屋の名前を持ってくるようにする
    public void selectRoom(string roomName)
    {

        if (script.O2tank == true && roomName == "02")
        {
            DoorScript = door_O2tank.GetComponent<OpenDoor>();
            O2_pargeClear = true;
        }
        else if (script.Storage == true && roomName == "storage")
            DoorScript = door_Storage.GetComponent<OpenDoor>();

        else if (script.Engine == true && roomName == "Engine")
            DoorScript = door_Storage.GetComponent<OpenDoor>();

        else if (script.Coffee == true && roomName == "Coffee")
            DoorScript = door_Storage.GetComponent<OpenDoor>();

        else if (script.Living == true && roomName == "Living")
            DoorScript = door_Storage.GetComponent<OpenDoor>();


    }
    // Update is called once per frame
    public void OnClick()
    {
        Debug.Log(script);
        if (DoorScript == null) return;
        DoorScript.CanOpenDoor = false;

       
    }
}
