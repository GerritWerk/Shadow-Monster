using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FimDeJogo : MonoBehaviour
{
    private bool Colider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)&& Colider)
		{
            SceneManager.LoadScene("Menu");
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
