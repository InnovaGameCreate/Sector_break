using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorStop : MonoBehaviour
{
    //O2incidentのクリア条件用のbool
    bool O2_purgeClear = false;

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
        

    }
    //他の場所から選択している部屋の名前を持ってくるようにする

    private void Update()
    {
        Debug.Log(DoorScript);
    }

    public void selectRoom(string roomName)
    {
        
            script = GameObject.Find("MainPanel").GetComponent<Button_identify>();

        
        if (script.O2 == true && roomName == "O2")
        {
            Debug.Log(roomName);
            DoorScript = door_O2tank.GetComponent<OpenDoor>();
            O2_purgeClear = true;
        } 
        else if (script.Storage == true && roomName == "Storage")
            DoorScript = door_Storage.GetComponent<OpenDoor>();

        else if (script.Engine == true && roomName == "Engine")
            DoorScript = door_Engineroom.GetComponent<OpenDoor>();

        else if (script.Coffee == true && roomName == "Coffee")
            DoorScript = door_Coffeeroom.GetComponent<OpenDoor>();

        else if (script.Living == true && roomName == "Living")
            DoorScript = door_Livingroom.GetComponent<OpenDoor>();

        

    }
    // Update is called once per frame
    public void OnClick()
    {
      
      
        if (DoorScript == null)
        {
            Debug.Log("無いよ");
         return;
        }
       else if(DoorScript != null)
        {
            Debug.Log("あるよ");
             DoorScript.CanOpendoor = false;
        }
      

    }
}
