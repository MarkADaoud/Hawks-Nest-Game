using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    private NavMeshAgent agent;

    public float radius;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
       if (!agent.hasPath)
        {
           agent.SetDestination( GetPoint.Instance.GetRandomPoint(transform, radius));
        }
    }

#if Unity_Editor

private void OnDrawGizmos ()
{
  Gizmos.DrawWireSphere (transform.position, radius);
}

#endif
}