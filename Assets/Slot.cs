using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Slot : MonoBehaviour
{
    public Item item;
    public Sprite sprite;
    public Image sr;
    public TextMeshProUGUI counter;
    void Update()
    {
        if (item == null)
        {
            Destroy(gameObject);
        }
        sr.sprite = sprite;
        counter.text = item.count+"";
    }
    public void PointClick()
    {
        item.Iteract.Use();
        Player.me.inventory.Remove(item.name);
        if (item.count <= 0) Destroy(gameObject);
    }
}
