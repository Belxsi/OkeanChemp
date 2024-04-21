using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float bulletSpeed;
    public float lifeTime;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = ShootControl.shootDir * bulletSpeed;
        if (rb.velocity.magnitude != 0)
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
