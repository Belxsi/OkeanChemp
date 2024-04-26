using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float bulletSpeed;
    public float lifeTime;
    public float damage=15;
    public int family=0;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
              rb.velocity = ShootControl.shootDir * bulletSpeed;
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y,-Vector2.Angle(Vector2.up,ShootControl.shootDir));

        if (rb.velocity.magnitude != 0)
            Invoke("Delete", lifeTime);
    }

    // Update is called once per frame
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            collision.GetComponent<Enemy>().life.Damage(damage);
        }
    }
    void Update()
    {
        
    }
    void Delete()
    {
        Destroy(gameObject);
    }
}
