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
    public int family;
    void Start()
    {
        physicMove = GetComponent<AIPhysicMove>();
        family = Random.Range(int.MinValue, int.MaxValue);
        
    }
    public void Update()
    {
        if (life.dead)
        {
            BaseFunc.AllLoadPrefab();
            Instantiate(BaseFunc.prefabs["DeadState"], transform.position, Quaternion.identity).GetComponent<SpriteRenderer>().sprite=DeadState;
            room.ememys.Remove(el);
            Destroy(gameObject);
        }
    }
    // Update is called once per frame

}
