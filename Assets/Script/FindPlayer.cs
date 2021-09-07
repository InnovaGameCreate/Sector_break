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
    private void Start()
    {
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
        yield return null;
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.F));
        player.SetActive(true);
        yield break;
    }
}
