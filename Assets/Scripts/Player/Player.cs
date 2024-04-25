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
    void Start()
    {
        physicMove = GetComponent<PhysicMove>();
        me = this;
    }

    // Update is called once per frame
    public Vector2 Move(List<KeyCode> Keycodes)
    {
        Vector2 sum = Vector2.zero ;
        for (int i = 0; i < Keycodes.Count; i++) {
            if(Input.GetKey(Keycodes[i]))
            switch (Keycodes[i])
            {
                    case KeyCode.W:
                        sum += Vector2.up;
                        break;
                    case KeyCode.S:
                        sum += Vector2.down;
                        break;
                    case KeyCode.D:
                        sum += Vector2.right;
                        break;
                    case KeyCode.A:
                        sum += Vector2.left ;
                        break;

                }
        }
        return sum;
    }
    void Update()
    {
        physicMove.MovementControl(Move(new (){KeyCode.W, KeyCode.S,KeyCode.D,KeyCode.R }),ref stats.speed);
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