using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
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
}
