using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EngineRoomTimer : MonoBehaviour
{
    [SerializeField]
    private float engineLimit = 450.0f;

    private bool IsEngine = true;
    private bool IsOnce = true;

    public float engineDouble;

    [SerializeField]
    GameObject electricManager;

    private void Start()
    {
        StartCoroutine("engineTimer");
    }

    public void OnClick()
    {
        StopCoroutine("engineTimer");
        IsEngine = false;
        StartCoroutine("engineTimer");
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
