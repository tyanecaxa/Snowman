using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public List<Transform> snowmanAFK;

    private NavMeshAgent _navMeshAgent;

    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _navMeshAgent.destination = snowmanAFK[Random.Range(0, snowmanAFK.Count)].position;
    }

    void Update()
    {
        if (_navMeshAgent.remainingDistance == 0)
        {
            _navMeshAgent.destination = snowmanAFK[Random.Range(0, snowmanAFK.Count)].position;

        }
    }

}
