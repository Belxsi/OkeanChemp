using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AIPhysicMove : MonoBehaviour
{
    // Start is called before the first frame update
    public NavMeshAgent agent;
    public TargetMove target;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public class TargetMove
{
    public Vector2 pos;
    public bool good;
    public float mindist;

    public TargetMove(Vector2 pos,float mindist=1)
    {
        this.pos = pos;
        this.mindist = mindist;
    }
}
