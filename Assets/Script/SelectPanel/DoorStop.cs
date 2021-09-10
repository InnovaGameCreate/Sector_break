using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorStop : MonoBehaviour
{
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

    Button_identify script;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void ButtonPushed()
    {
        Debug.Log("AA");
        if (script.O2tank == true)
        {
            script = GameObject.Find("mainPanel").GetComponent<Button_identify>();
            door_O2tank.GetComponent<OpenDoor>().enabled = false;
            Debug.Log("O2É^ÉìÉNÇ™ï¬çΩ");
        }
    }
}
