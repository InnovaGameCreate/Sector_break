using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickNo2 : MonoBehaviour
{
    [SerializeField]
    GameObject checkPanel;

    [SerializeField]
    GameObject buttonA;
    [SerializeField]
    GameObject player;
    public void OnClick()
    {
        Debug.Log("No");
        checkPanel.SetActive(false);
        buttonA.GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        player.GetComponent<PlayerController>().enabled = true;
    }
}
