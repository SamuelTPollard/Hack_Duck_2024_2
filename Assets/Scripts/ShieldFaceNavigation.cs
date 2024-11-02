using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ShieldFaceNavigation : MonoBehaviour
{
    public Transform player;
    public Camera playCam;
    private NavMeshAgent agent;
    public bool seen = false;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(playCam);

        if (GeometryUtility.TestPlanesAABB(planes, this.gameObject.GetComponent<Renderer>().bounds))
        {
            agent.speed = 0;
            agent.SetDestination(transform.position);
        }
        else
        {
            agent.speed = 6;
            agent.SetDestination(player.position);
        }
    }

}