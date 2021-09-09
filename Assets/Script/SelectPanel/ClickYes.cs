using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickYes : MonoBehaviour
{
    [SerializeField]
    GameObject checkPanel;

    [SerializeField]
    GameObject buttonA;

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

    public void OnClick()
    {
        Debug.Log("Yes");
        checkPanel.SetActive(false);
        buttonA.GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
    }
    public void OnClick(int number)
    {
        switch (number)
        {
            case 0://O2tank‘O‚Ì”à‚ğŠJ‚¯‚È‚­‚·‚é...‚Í‚¸
                door_O2tank.GetComponent<OpenDoor>().enabled = false;
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
        }//‹æ‰æ‚ÌŠeƒ{ƒ^ƒ“‚É‚»‚ê‚¼‚ê‚O`‚S‚ÌˆÙ‚È‚éˆø”‚ğ“n‚µ‚Ä‚­‚¾‚³‚¢B

    }
}
