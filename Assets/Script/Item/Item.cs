using System;
using UnityEngine;

[Serializable]
public class Item
{
    public enum Type
    {
        metal,
        electronical,
        spaceFood,
        water,
        plant,
        o2Tank,
        toys,
        spaceSuit,
        solarPanel,
    }

    public Type type;
    public Sprite sprite;

    public Item(Type type, Sprite sprite)
    {
        this.type = type;
        this.sprite = sprite;
    }
}
