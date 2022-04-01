using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TestInimigo : MonoBehaviour
{
    // Start is called before the first frame update

    private NavMeshAgent inimigo;
    private Transform ponto;
    public float setDistance;
    public float setRaio;
    void Start()
    {
        inimigo = GetComponent<NavMeshAgent>();
        ponto = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if(Physics.SphereCast(transform.position,setRaio,transform.forward,out hit, setDistance))
		{
            if(hit.transform.gameObject.tag == "Player")
			{
                inimigo.SetDestination(ponto.position);
            }
		}
        
        //inimigo.SetDestination(ponto.position);

    }
	
}
