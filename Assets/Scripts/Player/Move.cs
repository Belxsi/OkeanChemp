using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicMove : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void MovementControl(Vector2 dir)
    {
        rb.velocity = dir * speed * Time.deltaTime;
    }
}
