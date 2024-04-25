using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLogic : MonoBehaviour
{
    public Enemy enemy;
    public float timeout,time=1;
    public EnemyShooting es;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        es.UpdateLocal();
        if (timeout <= 0)
        {
            if (enemy.physicMove.target == null)
            {
                int i = 0;
                if (Vector2.Distance(Player.me.transform.position, transform.position) > 3)
                {
                    i = 1;
                }
                else i = -1;
                
                timeout = time;
                enemy.physicMove.target = new(Player.me.transform.position * i + new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f)));
            }
        }
        else
        {
            timeout -= Time.deltaTime;
        }
    }
}
