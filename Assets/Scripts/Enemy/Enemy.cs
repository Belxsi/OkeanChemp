using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public AIPhysicMove physicMove;
    public Stats stats;
    public RoomFighter room;
    public Sprite DeadState;
    public EnemyLogic el;
    public Life life;
    public Animator enemyAnim;
    void Start()
    {
        physicMove = GetComponent<AIPhysicMove>();
        life.life = stats.life;
        
    }
    public void Update()
    {
        if (life.dead)
        {
            BaseFunc.AllLoadPrefab();
            Instantiate(BaseFunc.prefabs["DeadState"], transform.position, Quaternion.identity).GetComponent<SpriteRenderer>().sprite=DeadState;
            room.ememys.Remove(el);
            Destroy(gameObject);
            gameObject.SetActive(false);
        }
        if (physicMove.agent.velocity.magnitude > 0)
            enemyAnim.SetBool("IsWalking", true);
        else
            enemyAnim.SetBool("IsWalking", false);
     
    }
    // Update is called once per frame
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            life.Damage(collision.gameObject.GetComponent<Shooting>().damage);
            Destroy(collision.gameObject);
        }
    }
}
