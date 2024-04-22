using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MonoBehaviour
{
    public Item item;
    public IIteractionItem Iteract;
    void Start()
    {
        item.Iteract = Iteract;
    }

    
    void Update()
    {
        
    }
}
