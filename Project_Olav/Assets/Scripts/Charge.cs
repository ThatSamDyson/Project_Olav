using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Charge : MonoBehaviour
{
    public Transform[] points;
    private int destPoint = 0;
    private NavMeshAgent agent;
    [SerializeField] GameObject hitcube;
    


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        //goToNextPoint();
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            goToNextPoint();
            GetComponent<BoxCollider>().enabled = false;
        }
    }


    void goToNextPoint()
    {
        if (points.Length == 0) return;

        agent.destination = points[destPoint].position;

        destPoint = (destPoint + 1) % points.Length;
    }

    void Update()
    {
        //if (!agent.pathPending && agent.remainingDistance < 0.5f)
        //{
        //    goToNextPoint();
        //}
    }
}
