using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public int damage;
    public float reloadSpeed;
    float tempReloadSpeed;
    GameObject bullet;
    public Animator enemyAnim;
    public float shootTime;

    // Start is called before the first frame update
    void Start()
    {
        tempReloadSpeed = reloadSpeed;
        BaseFunc.AllLoadPrefab();
        bullet = BaseFunc.prefabs["EnemyBullet"];
    }

    // Update is called once per frame
    public void UpdateLocal()
    {
        if (tempReloadSpeed <= 0)
        {
            Invoke("Shoot", shootTime);
            enemyAnim.SetTrigger("Shoot");
            tempReloadSpeed = reloadSpeed;
        }
        else
        {
            tempReloadSpeed -= Time.deltaTime;
        }
    }

    void Shoot()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
    }
}
