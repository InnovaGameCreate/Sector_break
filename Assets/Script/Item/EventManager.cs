using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{

    public float fixPartsEngine = 3.0f;
    public float fixPartsDoor = 5.0f;

    [SerializeField]
    GameObject enginefix;
    [SerializeField]
    GameObject doorfix;
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
        doorfix.GetComponent<DoorFix>().ClickElectronic();
        yield break;
    }

    IEnumerator metal()
    {
        enginefix.GetComponent<EngineFix>().ClickMetal();
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
