using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindPlayer_Item : MonoBehaviour
{
    Item item = default;

    IEnumerator routine;

    [SerializeField]
    GameObject text;

    [SerializeField]
    Item.Type itemType;

    [SerializeField]
    GameObject IsSlot;
    private void Start()
    {
        item = ItemGenerator.instance.Spawn(itemType);
        text.SetActive(false);
        routine = coroutine();
        IsSlot = GameObject.Find("Slot");
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
            StopCoroutine("coroutine");
            //routine = null;
            //routine = coroutine();
            text.SetActive(false);
        }
    }

    IEnumerator coroutine()
    {
        text.SetActive(true);
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.F));
        ItemBox.instance.SetItem(item);
        text.SetActive(false);
        yield break;
    }
}
