using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float bulletSpeed;
    public float lifeTime;
    public float damage;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = (Player.me.transform.position - transform.position).normalized * bulletSpeed;
        Invoke("Delete", lifeTime);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Delete()
    {
        Destroy(gameObject);
    }
}
