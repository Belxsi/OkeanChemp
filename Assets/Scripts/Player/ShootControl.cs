using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootControl : MonoBehaviour
{
    KeyCode shootingKey = KeyCode.Space;

    public static Vector2 shootDir;
    public GameObject aim;
    public GameObject bullet;
    void SetVector()
    {
        shootDir = BaseFunc.GetForMouseDir(transform.position);
        aim.transform.localPosition = shootDir;
        

    }
    void Start()
    {
        BaseFunc.AllLoadPrefab();
        bullet = BaseFunc.prefabs["Bullet"];
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
