using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    PhysicMove physicMove;
    public Stats stats;
  
  
    public Life life;
    void Start()
    {
        physicMove = GetComponent<PhysicMove>();
       
    }

    // Update is called once per frame
  
}
