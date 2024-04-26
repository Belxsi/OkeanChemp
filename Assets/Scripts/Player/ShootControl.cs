using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootControl : MonoBehaviour
{
    KeyCode shootingKey = KeyCode.Space;

    public static Vector2 shootDir;
    public GameObject aim;
    public GameObject bullet;
    public Animator playerAnim;
    public float shootTime;
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
        {
            playerAnim.SetTrigger("Shoot");
            Invoke("Shoot", shootTime);
        }
            
    }
    void Shoot()
    {
        Instantiate(bullet, gameObject.transform);
    }
}
