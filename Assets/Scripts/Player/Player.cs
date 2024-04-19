using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    PhysicMove physicMove;
    public Stats stats;
    void Start()
    {
        physicMove = GetComponent<PhysicMove>();
    }

    // Update is called once per frame
    void Update()
    {
        physicMove.MovementControl(new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")),ref stats.speed);
    }
}
[Serializable]
public class Stats
{
    public float life;
    public float speed;
}