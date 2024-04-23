using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AIPhysicMove : MonoBehaviour
{
    // Start is called before the first frame update
    public NavMeshAgent agent;
    public TargetMove target;
    public float timeout, time = 1f;
    void Start()
    {
        agent.updateRotation = false;
        agent.updatePosition = true;
        agent.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            if (timeout <= 0)
            {
                target.good = true;
                timeout = time;
            }
            else
            {
                timeout -=Time.deltaTime;
            }
            if (!target.good)
            {
                
                agent.SetDestination(target.pos);
                
                if (Vector2.Distance(target.pos, transform.position)<target.mindist)
                {
                    target.good = true;
                }
                if (agent.velocity.sqrMagnitude < 1f)
                {
                    target.good = true;
                }
            }
            else
            {
                target = null;
            }
        }
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
