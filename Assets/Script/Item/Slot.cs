using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    Item item = default;
    Image image = default;

    [SerializeField]
    Sprite nothing;
    private void Awake()
    {
        image = GetComponent<Image>();
    }

    private void Start()
    {

    }

    public bool IsEmpty()
    {
        if (item == null)
        {
            return true;
        }
        return false;
    }
    public void SetItem(Item item)
    {
        this.item = item;
        UpdateImage(item);
    }

    void UpdateImage(Item item)
    {
        image.sprite = item.sprite;
    }

    public void OnClick()
    {
        if (item != null)
        {
            EventManager.instance.EventHandle(item.type);
            image.sprite = nothing;
            item = null;
        }
    }
}
