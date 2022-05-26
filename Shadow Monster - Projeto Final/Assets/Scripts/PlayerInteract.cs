using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField] Camera camerai;
    [SerializeField] float distancia = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetButtonDown("E"))
		{
            Vector3 origem = camerai.ViewportToWorldPoint(new Vector3())
		}
    }
}
