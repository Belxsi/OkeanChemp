using UnityEngine;

public class PhysicMove : MonoBehaviour
{
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
   
    public void MovementControl(Vector2 dir,ref float speed)
    {
        rb.velocity = dir * speed * Time.deltaTime;
    }
}
