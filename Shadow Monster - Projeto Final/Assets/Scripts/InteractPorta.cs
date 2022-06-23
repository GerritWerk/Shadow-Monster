using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractPorta : MonoBehaviour
{

    public Animator animator;

    private bool colidir;
    private bool Porta_Abre = false;
   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.E)&& colidir)
		{
            Porta_Abre = true;
            animator.SetTrigger("Abrir");
        }
    }

	private void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.CompareTag("Player"))
		{
            colidir = true;
            
		}
	}

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.CompareTag("Player")) { 

			if (Porta_Abre)
			{
                animator.SetTrigger("Fechar");
			}
            colidir = false;
        }
    }
}