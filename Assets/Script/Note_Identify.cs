using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Note_Identify : MonoBehaviour
{
    [SerializeField]  GameObject Memo1;

    [SerializeField] GameObject Memo2;

    [SerializeField] GameObject Memo3;

    [SerializeField] GameObject Memo4;

    [SerializeField] GameObject Memo5;

    [SerializeField] GameObject Back;

    [SerializeField]
    GameObject ItemBar;

    [SerializeField]
    GameObject NoteDeviceButton;

    // Start is called before the first frame update
    public void OnClick(int number)
    {
        switch (number)
        {
            case 0:
                Memo1.SetActive(true);
                Memo2.SetActive(false);
                Memo3.SetActive(false);
                Memo4.SetActive(false);
                Memo5.SetActive(false);
                break;
            case 1:
                Memo1.SetActive(false);
                Memo2.SetActive(true);
                Memo3.SetActive(false);
                Memo4.SetActive(false);
                Memo5.SetActive(false);
                break;
            case 2:
                Memo1.SetActive(false);
                Memo2.SetActive(false);
                Memo3.SetActive(true);
                Memo4.SetActive(false);
                Memo5.SetActive(false);
                break;
            case 3:
                Memo1.SetActive(false);
                Memo2.SetActive(false);
                Memo3.SetActive(false);
                Memo4.SetActive(true);
                Memo5.SetActive(false);
                break;
            case 4:
                Memo1.SetActive(false);
                Memo2.SetActive(false);
                Memo3.SetActive(false);
                Memo4.SetActive(false);
                Memo5.SetActive(true);
                break;
            case 5:
               
                Back.SetActive(false);
                ItemBar.SetActive(true);
                NoteDeviceButton.SetActive(true);
                break;
            default:
                break;
        }
    }
}
