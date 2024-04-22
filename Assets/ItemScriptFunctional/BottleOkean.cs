using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class BottleOkean :  MonoBehaviour,IIteractionItem
{
    public ItemObject Object;
    public void Start()
    {
        Object = GetComponent<ItemObject>();
        Object.item.Iteract = this;
    }
   
    public void Use()
    {
        Player.me.life.Damage(-5);
    }

 
   
   
}
