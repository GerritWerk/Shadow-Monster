using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class TestInimigo : MonoBehaviour
{
    // Start is called before the first frame update

    public NavMeshAgent agent;
    public bool Seguir;
    public float WaitTime;
    public Transform visaoLocal;
    public LayerMask layoso;
    public GameObject ponto1;
    public GameObject ponto2;
    public GameObject ponto3;
    public GameObject ponto4;
    public GameObject ponto5;

    //public Animator animator;
    public Light olhos;
   // public Light olho2;

    public Vector3 Latspos;
    GameObject ponto_Atual;
    //Seguir seguir;
    void Start()
    {
        
        ponto_Atual = ponto1;
    }

    // Update is called once per frame
    void Update()
    {

        Pratrulha();
        Seguindo();
       // animator.Play("mixamo_com");
        
	}
    public void Pratrulha()
	{
        olhos.enabled = false;
        //olho2.enabled = false;
        agent.speed = 2;
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
            if (WaitTime <= 5)
                WaitTime += 1 * Time.deltaTime;
            if (agent.destination != Latspos)
            {
                Pratrulha();
            }
        }

        if (WaitTime <= 5)
        {
            olhos.enabled = true;
            //olho2.enabled=true;
            agent.speed = 5;
            RaycastHit Hit = new RaycastHit();
            visaoLocal.LookAt(agent.destination = GameObject.FindWithTag("Player").transform.position);
            if (Physics.Raycast(visaoLocal.position, visaoLocal.forward, out Hit, 500, layoso, QueryTriggerInteraction.Ignore))
            {
                Debug.DrawLine(visaoLocal.position, Hit.point, Color.green);
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

    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "Player"){
            SceneManager.LoadScene("SampleScene");
        }
    }
}
