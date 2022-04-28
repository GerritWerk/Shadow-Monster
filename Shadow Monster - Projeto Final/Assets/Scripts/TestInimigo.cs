using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TestInimigo : MonoBehaviour
{
    // Start is called before the first frame update

    public NavMeshAgent agent;
    public bool Seguir;
    public float WaitTime;
    public Transform visãoLocal;
    public LayerMask layoso;

    private Vector3 Latspos;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Seguir == true)
        {
            WaitTime = 0;
        }
		else
		{
            if (WaitTime <= 2)
                WaitTime += 1 * Time.deltaTime;
            if(agent.destination != Latspos){
                agent.destination = Latspos;
            }
		}

        if(WaitTime <= 2)
		{
            RaycastHit Hit = new RaycastHit();
            visãoLocal.LookAt(agent.destination = GameObject.FindWithTag("Player").transform.position);
            if (Physics.Raycast(visãoLocal.position, visãoLocal.forward, out Hit, 500, layoso, QueryTriggerInteraction.Ignore)) {
                Debug.DrawLine(visãoLocal.position, Hit.point, Color.green);
                if (Hit.transform.gameObject.tag == "Player")
                {
                    agent.destination = GameObject.FindWithTag("Player").transform.position;
                }

				else
				{
                    if (agent.destination != Latspos)
                    {
                        agent.destination = Latspos;
                    }
                }
            }
			else
			{
                if (agent.destination != Latspos)
                {
                    agent.destination = Latspos;
                }
            }
        }
	}

	
}
