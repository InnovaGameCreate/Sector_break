using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindPlayer : MonoBehaviour
{
    IEnumerator routine;

    [SerializeField]
    GameObject text;
    [SerializeField]
    GameObject player;
    [SerializeField]
    GameObject panel;
    private void Start()
    {
        panel.SetActive(false);
        text.SetActive(false);
        routine = coroutine();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine("coroutine");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            routine = null;
            routine = coroutine();
            text.SetActive(false);
        }
    }

    IEnumerator coroutine()
    {
        text.SetActive(true);
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.F));
        player.SetActive(false);
        text.SetActive(false);
        panel.SetActive(true);
        yield return null;
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.F));
        player.SetActive(true);
        panel.SetActive(false);
        yield break;
    }
}
