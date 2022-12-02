using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cartões : MonoBehaviour
{
    // Start is called before the first frame update
    private bool Colider;
    public bool Com_Cartao;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)&& Colider)
		{
            Com_Cartao = true;
            //Destroy(gameObject);
		}
    }

	private void OnTriggerEnter(Collider col)
	{
        if (col.gameObject.CompareTag("Player"))
        {
            Colider = true;

        }
    }

   
}
