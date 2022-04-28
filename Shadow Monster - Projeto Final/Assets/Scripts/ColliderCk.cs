using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderCk : MonoBehaviour
{
    public TestInimigo script;
	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			script.Seguir = true;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player")
		{
			script.Seguir = false;
		}
	}
}
