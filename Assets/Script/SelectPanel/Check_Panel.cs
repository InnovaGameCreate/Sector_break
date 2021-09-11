using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check_Panel : MonoBehaviour
{
    [SerializeField] GameObject checkPanel;

    // Start is called before the first frame update
    void Start()
    {
        checkPanel.SetActive(false);
    }

    public void onclick()
    {
        checkPanel.SetActive(true);
    }

    public void choise()
    {
        checkPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
