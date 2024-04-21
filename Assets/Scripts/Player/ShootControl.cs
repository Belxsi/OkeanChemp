using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootControl : MonoBehaviour
{
    KeyCode shootingKey = KeyCode.Space;

    public static Vector2 shootDir;
    public GameObject aim;
    GameObject bullet;
    void SetVector()
    {
        shootDir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        aim.transform.localPosition = shootDir;
        bullet = GameObject.FindWithTag("Bullet");

    }
    void Start()
    {
        
    }

    void Update()
    {
        SetVector();
        if (Input.GetKeyDown(shootingKey))
            Shoot();
    }
    void Shoot()
    {
        Instantiate(bullet, gameObject.transform);
    }
}
