using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    PhysicMove physicMove;
    public Stats stats;
    public Inventory inventory;
    public static Player me;
    public Life life;
    public Animator playerAnim;
    void Start()
    {
        physicMove = GetComponent<PhysicMove>();
        me = this;
        life.life = stats.life;
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
        Vector2 pos = Move(new() { KeyCode.W, KeyCode.S, KeyCode.D, KeyCode.A });

        physicMove.MovementControl(pos,ref stats.speed);

        if (pos == Vector2.zero)
            playerAnim.SetBool("IsWalking", false);
        else
            playerAnim.SetBool("IsWalking", true);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            life.Damage(collision.gameObject.GetComponent<EnemyBullet>().damage);
            Destroy(collision.gameObject);
        }
        physicMove.MovementControl(Move(new (){KeyCode.W, KeyCode.S,KeyCode.D,KeyCode.A }),ref stats.speed);
        
    }
    public void Dead()
    {
        if (life.dead)
        {
            BaseFunc.AllLoadPrefab();
            Instantiate( BaseFunc.prefabs["DeadMenu"]);
        }
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