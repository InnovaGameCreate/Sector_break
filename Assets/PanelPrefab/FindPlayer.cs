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
    GameObject panel;
    [SerializeField]
    GameObject player;

    private GameObject Player;
    private GameObject a;
    private void Start()
    {
        panel.SetActive(false);
        text.SetActive(false);
        routine = coroutine();
        player.GetComponent<PlayerController>().enabled = true;
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
        player.GetComponent<PlayerController>().enabled = false;
        text.SetActive(false);
        panel.SetActive(true);
        yield return null;
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.F));
        player.GetComponent<PlayerController>().enabled = true;
        panel.SetActive(false);
        yield break;
    }
}
