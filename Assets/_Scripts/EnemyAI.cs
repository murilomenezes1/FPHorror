using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{


	public GameObject EnemyDestination;
	NavMeshAgent EnemyAgent;

    // Start is called before the first frame update
    void Start()
    {

    	EnemyAgent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {

    	EnemyAgent.SetDestination(EnemyDestination.transform.position);
        
    }
}
