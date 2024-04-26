using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Win : MonoBehaviour,IIteractionItem
{

    public ItemObject Object;
    public void Start()
    {
        Object = GetComponent<ItemObject>();
        Object.item.Iteract = this;
    }

    public void Use()
    {
        SceneManager.LoadScene("Menu");
    }
}
