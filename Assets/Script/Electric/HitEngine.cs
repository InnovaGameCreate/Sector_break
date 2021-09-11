using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitEngine : MonoBehaviour
{
    IEnumerator routine;
    [SerializeField]
    GameObject checkF;
    [SerializeField]
    GameObject panel;
    [SerializeField]
    GameObject player;
    private void Start()
    {
        panel.SetActive(false);
        routine = coroutine();
        player.GetComponent<PlayerController>().enabled = true;
        checkF.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (GetComponent<EngineFix>().IsEngineActive == true)
            {
                checkF.SetActive(true);
                Debug.Log("“Ç‚Ýž‚Ý");
                StartCoroutine("coroutine");
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            checkF.SetActive(false);
            routine = null;
            routine = coroutine();
        }
    }

    IEnumerator coroutine()
    {
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.F));
        checkF.SetActive(false);
        player.GetComponent<PlayerController>().enabled = false;
        panel.SetActive(true);
        yield return null;
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.F));
        player.GetComponent<PlayerController>().enabled = true;
        panel.SetActive(false);
        yield break;
    }
}
