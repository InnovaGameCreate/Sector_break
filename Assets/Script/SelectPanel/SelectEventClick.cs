using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectEventClick : MonoBehaviour
{
    [SerializeField]
    GameObject checkPanel;

    [SerializeField]
    GameObject buttonA;

    private void Start()
    {
        checkPanel.SetActive(false);
    }
    public void OnClick()
    {
        buttonA.GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
        Debug.Log("‰Ÿ‚³‚ê‚½");
        checkPanel.SetActive(true);
        StartCoroutine("WaitFKey");
    }

    IEnumerator WaitFKey()
    {
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.F));
        buttonA.GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        checkPanel.SetActive(false);
        yield break;
    }
}
