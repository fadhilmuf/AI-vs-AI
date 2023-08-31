using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    void Update()
    {
        FindNearestObject();
    }

    void FindNearestObject()
    {
        GameObject[] rocks = GameObject.FindGameObjectsWithTag("Rock");
        GameObject[] papers = GameObject.FindGameObjectsWithTag("Paper");
        GameObject[] scissors = GameObject.FindGameObjectsWithTag("Scissor");
        
        GameObject target = null;

        if (gameObject.CompareTag("Rock"))
        {
            if (scissors.Length > 0)
            {
                target = scissors[0];
            }
            else if (papers.Length > 0)
            {
                target = papers[0];
            }
        }
        else if (gameObject.CompareTag("Paper"))
        {
            if (rocks.Length > 0)
            {
                target = rocks[0];
            }
            else if (scissors.Length > 0)
            {
                target = scissors[0];
            }
        }
        else if (gameObject.CompareTag("Scissor"))
        {
            if (papers.Length > 0)
            {
                target = papers[0];
            }
            else if (rocks.Length > 0)
            {
                target = rocks[0];
            }
        }

        if (target != null)
        {
            agent.SetDestination(target.transform.position);
            agent.speed = 3f;
        }
    }
}
