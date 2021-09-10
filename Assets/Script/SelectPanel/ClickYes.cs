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

    

    public void OnClick()
    {
        Debug.Log("Yes");
        checkPanel.SetActive(false);
        buttonA.GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
    }
    
}
