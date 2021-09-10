using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public float iraira = 100.0f;

    public float fixParts = 3.0f;

    public static EventManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    private void Start()
    {
        Debug.Log(iraira);
    }

    public void EventHandle(Item.Type type)
    {
        switch (type)
        {
            case Item.Type.electronical:
                StartCoroutine("electronical");
                Debug.Log(type);
                break;

            case Item.Type.metal:
                StartCoroutine("metal");
                Debug.Log(type);
                break;

            case Item.Type.spaceFood:
                StartCoroutine("spaceFood");
                Debug.Log(type);
                break;

            case Item.Type.water:
                StartCoroutine("water");
                Debug.Log(type);
                break;

            case Item.Type.plant:
                StartCoroutine("plant");
                Debug.Log(type);
                break;

            case Item.Type.o2Tank:
                StartCoroutine("o2Tank");
                Debug.Log(type);
                break;

            case Item.Type.toys:
                StartCoroutine("toys");
                Debug.Log(type);
                break;

            case Item.Type.spaceSuit:
                StartCoroutine("spaceSuit");
                Debug.Log(type);
                break;

            case Item.Type.solarPanel:
                StartCoroutine("solarpanel");
                Debug.Log(type);
                break;

        }
    }

    IEnumerator electronical()
    {
        iraira = iraira + 5;
        Debug.Log(iraira);
        yield break;
    }

    IEnumerator metal()
    {
        fixParts = fixParts - 1;
        Debug.Log("�C�������܂Ŏc��" + fixParts + "��");
        yield break;
    }

    IEnumerator spaceFood()
    {
        yield break;
    }

    IEnumerator water()
    {
        yield break;
    }

    IEnumerator plant()
    {
        yield break;
    }

    IEnumerator o2Cylinder()
    {
        yield break;
    }

    IEnumerator toys()
    {
        yield break;
    }

    IEnumerator spaceSuit()
    {
        yield break;
    }

    IEnumerator solarpanel()
    {
        yield break;
    }
}
