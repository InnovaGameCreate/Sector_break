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

    [SerializeField] GameObject Memo0;

    [SerializeField] GameObject Back;

    [SerializeField]
    GameObject ItemBar;

    [SerializeField]
    GameObject NoteDeviceButton;

    EngineFix enginefix;
    DoorFix doorfix;
    SolarFix solarfix;

    // Start is called before the first frame update
    public void Start()
    {
        enginefix = GetComponent<EngineFix>();
        doorfix = GetComponent<DoorFix>();
        solarfix = GetComponent<SolarFix>();
    }
    public void OnClick(int number)
    {
        switch (number)
        {
            case 0:
                if (enginefix.EngineFixClear1 == false)
                {
                    Memo0.SetActive(false); 
                Memo1.SetActive(true);
                Memo2.SetActive(false);
                Memo3.SetActive(false);
                Memo4.SetActive(false);
                Memo5.SetActive(false);
                                  
                }
                break;
            case 1:
                if (doorfix.DoorFixClear == true)
                {
                    Memo0.SetActive(false);
                    Memo1.SetActive(false);
                    Memo2.SetActive(true);
                    Memo3.SetActive(false);
                    Memo4.SetActive(false);
                    Memo5.SetActive(false);
                    
                }
                
                break;
            case 2:
                if (solarfix.SolarFixClear == true)
                {
                    Memo0.SetActive(false);
                    Memo1.SetActive(false);
                Memo2.SetActive(false);
                Memo3.SetActive(true);
                Memo4.SetActive(false);
                Memo5.SetActive(false);
                    
                }
               
                break;
            case 3:
                if (doorfix.DoorFixClear == true)
                {
                    Memo0.SetActive(false);
                    Memo1.SetActive(false);
                    Memo2.SetActive(false);
                    Memo3.SetActive(false);
                    Memo4.SetActive(true);
                    Memo5.SetActive(false);
                    
                }
                break;
            case 4:
                if (solarfix.SolarFixClear == true)
                {
                    Memo0.SetActive(false);
                    Memo1.SetActive(false);
                    Memo2.SetActive(false);
                    Memo3.SetActive(false);
                    Memo4.SetActive(false);
                    Memo5.SetActive(true);
                    
                }
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
