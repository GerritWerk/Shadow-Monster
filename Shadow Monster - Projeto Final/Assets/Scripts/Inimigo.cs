using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Inimigo : MonoBehaviour
{
	public NavMeshAgent agent;

	public Transform player;

	public LayerMask whatIsGround, whatIsPlayer;

	//patrulha
	public Vector3 walkPoint;
	bool walkPointSet;
	public float walkPointRange;

	//States
	public float sightRange, attackRange;
	public bool playerInSightRange, playerInAttackRange;

	private void Awake()
	{
		player = GameObject.Find("Player").transform;
		agent = GetComponent<NavMeshAgent>();
	}

	private void Update()
	{
		playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
		playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);

		if (!playerInSightRange && !playerInAttackRange) Patrulha();
		if (playerInSightRange && !playerInAttackRange) ChasePlayer();
	}

	private void Patrulha()
	{
		if (!walkPointSet) SearchWalkPoint();

		if (walkPointSet)
		{
			agent.SetDestination(walkPoint);
		}

		Vector3 distanceToWalkPoint = transform.position - walkPoint;

		if(distanceToWalkPoint.magnitude < 1f)
		{
			walkPointSet = false;
		}
	}

	private void SearchWalkPoint()
	{
		float randomZ = Random.Range(-walkPointRange, walkPointRange);
		float randomX = Random.Range(-walkPointRange, walkPointRange);

		walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);

		if (Physics.Raycast(walkPoint, -transform.up, 2f, whatIsGround))
		{
			walkPointSet = true;
		}
	}

	private void ChasePlayer()
	{
		agent.SetDestination(player.position);
	}
}
