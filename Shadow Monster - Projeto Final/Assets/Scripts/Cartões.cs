using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cartões : MonoBehaviour
{
    // Start is called before the first frame update
    private bool Colider;
    public bool Com_Cartao = false;
    public AudioSource peguei;
    void Start()
    {
        peguei = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)&& Colider)
		{
            Com_Cartao = true;
            gameObject.SetActive(false);
            peguei.Play();
            //Debug.Log("Peguei?");
		}
    }

	private void OnTriggerEnter(Collider col)
	{
        if (col.gameObject.CompareTag("Player"))
        {
            Colider = true;
            //Debug.Log("Tafufando?");
        }
    }

    public bool FoiPega(){
        return Com_Cartao;
    }

   
}
