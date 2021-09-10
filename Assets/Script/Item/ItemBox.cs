using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    [SerializeField]
    Slot[] slots = default;

    public static ItemBox instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

            slots = GetComponentsInChildren<Slot>();
        }
    }
    public void SetItem(Item item)
    {
        foreach (Slot slot in slots)
        {
            if (slot.IsEmpty())
            {
                slot.SetItem(item);
                break;
            }
        }
    }
}
