using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Inventory : MonoBehaviour
{
    public Dictionary<string, Item> items = new();
    void Start()
    {
        
    }

    public void Add(ItemObject io)
    {
        if (items.TryGetValue(io.item.name,out Item value))
        {
            value.count++;
        }
        else
        {
            items.Add(io.item.name, io.item);
        }
    }
    public void Remove(ItemObject io)
    {
        if (items.TryGetValue(io.item.name, out Item value))
        {

            if (value.count > 1)
            {
                value.count--;
            }
            else
            {
                items.Remove(io.name);
            }
        }
        else
        {
            items.Add(io.item.name, io.item);
        }
    }
    public void Remove(string name)
    {
        if (items.TryGetValue(name, out Item value))
        {

            if (value.count > 1)
            {
                value.count--;
            }
            else
            {
                items.Remove(name);
            }
        }
        else
        {
            items.Add(name,value);
        }
    }
    public void Replace()
    {

    }
    void Update()
    {
        
    }
}
[Serializable]
public class Item
{
    public int count;
    public string name;
}
