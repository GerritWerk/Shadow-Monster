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
    public GameObject ponto1;
    public GameObject ponto2;
    public GameObject ponto3;
    public GameObject ponto4;
    public GameObject ponto5;

    public Animator animator;

    private Vector3 Latspos;
    GameObject ponto_Atual;
    void Start()
    {
        
        ponto_Atual = ponto1;
    }

    // Update is called once per frame
    void Update()
    {

        Pratrulha();
        Seguindo();
        
	}
    private void Pratrulha()
	{
        agent.SetDestination(ponto_Atual.transform.position);
	}
	private void Seguindo()
	{
        if (Seguir == true)
        {
            WaitTime = 0;
        }
        else
        {
            if (WaitTime <= 2)
                WaitTime += 1 * Time.deltaTime;
            if (agent.destination != Latspos)
            {
                Pratrulha();
            }
        }

        if (WaitTime <= 2)
        {
            RaycastHit Hit = new RaycastHit();
            visãoLocal.LookAt(agent.destination = GameObject.FindWithTag("Player").transform.position);
            if (Physics.Raycast(visãoLocal.position, visãoLocal.forward, out Hit, 500, layoso, QueryTriggerInteraction.Ignore))
            {
                Debug.DrawLine(visãoLocal.position, Hit.point, Color.green);
                if (Hit.transform.gameObject.tag == "Player")
                {
                    agent.destination = GameObject.FindWithTag("Player").transform.position;
                }

                else
                {
                    if (agent.destination != Latspos)
                    {
                        Pratrulha();
                    }
                }
            }
            else
            {
                if (agent.destination != Latspos)
                {
                    Pratrulha();
                }
            }
        }
    }

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name.Equals(ponto1.gameObject.name))
		{
            ponto_Atual = ponto2;
            //animator.Play("Patrulha");
		}
        else if (other.gameObject.name.Equals(ponto2.gameObject.name))
        {
            ponto_Atual = ponto3;

        }
        else if (other.gameObject.name.Equals(ponto3.gameObject.name))
        {
            ponto_Atual = ponto4;
        }
        else if (other.gameObject.name.Equals(ponto4.gameObject.name))
        {
            ponto_Atual = ponto5;
        }
        else if (other.gameObject.name.Equals(ponto5.gameObject.name))
        {
            ponto_Atual = ponto1;
        }
        Pratrulha();
	}
}
