using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public AIPhysicMove physicMove;
    public Stats stats;
    
  
  
    public Life life;
    void Start()
    {
        physicMove = GetComponent<AIPhysicMove>();
        
        
    }

    // Update is called once per frame
  
}
