using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryInterface : MonoBehaviour
{

    public Transform content;
    public static InventoryInterface me;
    public void Awake()
    {
        me = this;
    }
    public void AddSlot(Item item)
    {
        BaseFunc.AllLoadPrefab();
        GameObject slot =BaseFunc.prefabs["Slot"];
        Slot sl =Instantiate(slot, content).GetComponent<Slot>();
        sl.item = item;
    }
}
