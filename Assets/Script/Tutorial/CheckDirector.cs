using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckDirector : MonoBehaviour
{
    Image checkA;
    void Start()
    {
        checkA = GameObject.Find("Canvas/Check").GetComponent<Image>();
        StartCoroutine("WASD");
        checkA.enabled = false;
    }

    IEnumerator WASD()
    {
        yield return new WaitUntil(() => Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D));
        checkA.enabled = true;
        yield break;
    }
}