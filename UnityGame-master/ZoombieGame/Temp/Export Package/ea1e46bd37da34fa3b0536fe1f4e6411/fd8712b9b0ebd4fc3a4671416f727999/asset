// MoveTo.cs
using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class ZombieMove : MonoBehaviour
{

	public GameObject goal;
	private NavMeshAgent agent;

	void Start()
	{
		goal= GameObject.FindGameObjectWithTag("Player");
		agent = GetComponent<NavMeshAgent>();
		agent.destination = goal.transform.position;
	}

	void Update()
	{
		agent.destination = goal.transform.position;
	}
	
}