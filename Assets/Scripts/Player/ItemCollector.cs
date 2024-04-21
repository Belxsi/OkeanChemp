using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    public GameObject collectInterface;
    public bool active;
    public ItemObject itemO;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if (active)
        {
            if (Input.GetKeyUp(KeyCode.E)){
                Player.me.inventory.Add(itemO);

                Destroy(gameObject);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collectInterface.SetActive(true);
            active = true;

        }
        //collectInterface.SetActive(true);
        Debug.Log(collision.gameObject.tag);
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collectInterface.SetActive(false);
            active = false ;
        }
    }
}
