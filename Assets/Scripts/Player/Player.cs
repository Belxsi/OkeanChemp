using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    PhysicMove physicMove;
    public Stats stats;
    public Inventory inventory;
    public static Player me;
    public Life life;
    Animator playerAnim;
    void Start()
    {
        physicMove = GetComponent<PhysicMove>();
        playerAnim = GetComponent<Animator>();
        me = this;
    }

    // Update is called once per frame
    void Update()
    {
        physicMove.MovementControl(new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")),ref stats.speed);
    }
}
[Serializable]
public class Stats
{
    public float life;
    public float speed;
}
[Serializable]
public class Life
{
    public float life;
    public bool dead;
    public void Damage(float damage)
    {
        if (!dead)
        {
            life -= damage;
            if (life < 0)
            {
                dead = true;
            }
        }
    }
}