using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraToPlayer : MonoBehaviour
{
    public GameObject player;
    public float followSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CameraFollowing();
    }
    void CameraFollowing()
    {
        transform.position += (player.transform.position - transform.position) * followSpeed * Time.deltaTime;
        transform.position = new Vector3(transform.position.x, transform.position.y, -10f);
    }
}
