using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorStop : MonoBehaviour
{
    

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

    [SerializeField]
    GameObject O2room;

    [SerializeField]
    GameObject Storageroom;

    [SerializeField]
    GameObject Engineroom;

    [SerializeField]
    GameObject Coffeeroom;

    [SerializeField]
    GameObject Livingroom;

    Button_identify script;

    OpenDoor DoorScript;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("DoorRevive");

    }
    //ëºÇÃèÍèäÇ©ÇÁëIëÇµÇƒÇ¢ÇÈïîâÆÇÃñºëOÇéùÇ¡ÇƒÇ≠ÇÈÇÊÇ§Ç…Ç∑ÇÈ

    private void Update()
    {
        
    }

    public void selectRoom(string roomName)
    {
        Debug.Log("a");
         script = GameObject.Find("MainPanel").GetComponent<Button_identify>();


        if (script.O2 == true && roomName == "O2")
        {
            Debug.Log(roomName);
            DoorScript = door_O2tank.GetComponent<OpenDoor>();
            O2room.SetActive(false);
            gameSystem.isIncindent2 = true;
        }
        else if (script.Storage == true && roomName == "Storage")
        {
            DoorScript = door_Storage.GetComponent<OpenDoor>();
            Storageroom.SetActive(false);
        }
        else if (script.Engine == true && roomName == "Engine")
        {
            DoorScript = door_Engineroom.GetComponent<OpenDoor>();
            Engineroom.SetActive(false);
        }
        else if (script.Coffee == true && roomName == "Coffee")
        {
            DoorScript = door_Coffeeroom.GetComponent<OpenDoor>();
            Coffeeroom.SetActive(false);
        }

        else if (script.Living == true && roomName == "Living")
        { 
            DoorScript = door_Livingroom.GetComponent<OpenDoor>();
 
                 Livingroom.SetActive(false);
             
            
           
           
        } 

        

    }
    // Update is called once per frame
    public void OnClick()
    {
      
      
        if (DoorScript == null)
        {
            Debug.Log("ñ≥Ç¢ÇÊ");
         return;
        }
       else if(DoorScript != null)
        {
            Debug.Log("Ç†ÇÈÇÊ");
             DoorScript.CanOpendoor = false;
        }
      

    }
}
