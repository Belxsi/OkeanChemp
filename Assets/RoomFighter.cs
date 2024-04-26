using System.Collections.Generic;
using UnityEngine;

public class RoomFighter : MonoBehaviour
{
    public List<EnemyLogic> ememys = new();
    public List<GameObject> walls = new();
    public bool active, good;
    public bool wallsset;
    public void Start()
    {
        for (int i = 0; i < walls.Count; i++)
        {
            walls[i].SetActive(false);
        }
        for (int i = 0; i < ememys.Count; i++)
        {
            ememys[i].enabled = false;
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {

        if ((!good) & (!active))
            if (collision.CompareTag("Player"))
            {

                active = true;
            }
    }
    // Update is called once per frame
    void Update()
    {
        if (active)
        {
            if (!wallsset)
            {
                for (int i = 0; i < walls.Count; i++)
                {
                    walls[i].SetActive(true);
                }
                for (int i = 0; i < ememys.Count; i++)
                {
                    ememys[i].enabled = true;
                }
                wallsset = true;
            }

            if (ememys.Count <= 0)
            {
                good = true;
                active = false;
                for (int i = 0; i < walls.Count; i++)
                {
                    walls[i].SetActive(false);
                }
            }
        }
    
    }
}
