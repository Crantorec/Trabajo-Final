using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class MoveTo : MonoBehaviour
{
    NavMeshAgent agent; //Componente nav mesh agent
    public Transform[] WayPoints; //Lista de waypoints
    public int indexWaypoint = 0;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>(); //Obtenemos el componente

        agent.SetDestination(WayPoints[indexWaypoint].position);


    }

    // Update is called once per frame
    void Update()
    {
        if (agent.remainingDistance == 0)
        {
            indexWaypoint = (indexWaypoint + 1) % WayPoints.Length;
            agent.SetDestination(WayPoints[indexWaypoint].position);
        }
    }
}
