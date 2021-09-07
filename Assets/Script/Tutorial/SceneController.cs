using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    void Start()
    {
        StartCoroutine("tutorial");
    }

    IEnumerator tutorial()
    {
        yield return new WaitUntil(() => transform.position.x > 450.0f);
        GameObject[] cubes = GameObject.FindGameObjectsWithTag("tutorial");
        foreach (GameObject cube in cubes)
        {
            Destroy(cube);
        }
    }
}