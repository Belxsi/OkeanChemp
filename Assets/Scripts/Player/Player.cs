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
    bool IsWalking()
    {
        return Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D);
    }
    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");
        physicMove.MovementControl(new Vector2(hor, ver), ref stats.speed);
        if (IsWalking())
            playerAnim.SetBool("isWalking", true);
        else
            playerAnim.SetBool("isWalking", true);
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