using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickYes2 : MonoBehaviour
{
    [SerializeField]
    private float engineLimit = 450.0f;

    private bool IsEngine = true;
    private bool IsOnce = true;

    [SerializeField]
    GameObject electricManager;
    [SerializeField]
    GameObject checkPanel;

    [SerializeField]
    GameObject buttonA;
    [SerializeField]
    GameObject player;
    private void Start()
    {
        StartCoroutine("engineTimer");
    }

    public void OnClick()
    {
        StopCoroutine("engineTimer");
        IsEngine = false;
        buttonA.GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        StartCoroutine("engineTimer");
        checkPanel.SetActive(false);
        player.GetComponent<PlayerController>().enabled = true;
    }

    IEnumerator engineTimer()
    {
        if (IsEngine == true)
        {
            yield return new WaitForSeconds(engineLimit);
            Debug.Log("YouDead");
        }
        else if (IsEngine == false && IsOnce == true)
        {
            IsOnce = false;
            electricManager.GetComponent<electricData>().EngineClick();
        }
        else
        {
            yield break;
        }
    }
}
