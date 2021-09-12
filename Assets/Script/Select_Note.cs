using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Select_Note : MonoBehaviour
{
    [SerializeField]
    GameObject NotePanel;

    [SerializeField]
    GameObject button;

    [SerializeField]
    GameObject ItemBar;


    [SerializeField]
    GameObject NoteDeviceButton;
    // Start is called before the first frame update
    void Start()
    {
        NotePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
       
        Debug.Log("‰Ÿ‚³‚ê‚½");
        ItemBar.SetActive(false);
        NoteDeviceButton.SetActive(false);
        NotePanel.SetActive(true);
        
    }
    
}
