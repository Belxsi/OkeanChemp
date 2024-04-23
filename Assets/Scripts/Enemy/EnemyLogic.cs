using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLogic : MonoBehaviour
{
    public Enemy enemy;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(enemy.physicMove.target==null)
        enemy.physicMove.target = new(Player.me.transform.position);
    }
}
