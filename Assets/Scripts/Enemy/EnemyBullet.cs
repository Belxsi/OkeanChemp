using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float bulletSpeed;
    public float damage=5;
    public float lifeTime;
    public int family;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = (Player.me.transform.position - transform.position).normalized * bulletSpeed;
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<Player>().life.Damage(damage);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
