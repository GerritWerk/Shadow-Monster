using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguir : MonoBehaviour
{
    TestInimigo Ini;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void Seguindo()
	{
		if (Ini.Seguir == true)
		{
			Ini.WaitTime = 0;
		}
		else
		{
			if (Ini.WaitTime <= 5)
				Ini.WaitTime += 1 * Time.deltaTime;
			if (Ini.agent.destination != Ini.Latspos)
			{
				Ini.Pratrulha();
			}
		}

		if (Ini.WaitTime <= 5)
		{
			Ini.olhos.enabled = true;
			//olho2.enabled=true;
			Ini.agent.speed = 5;
			RaycastHit Hit = new RaycastHit();
			Ini.visaoLocal.LookAt(Ini.agent.destination = GameObject.FindWithTag("Player").transform.position);
			if (Physics.Raycast(Ini.visaoLocal.position, Ini.visaoLocal.forward, out Hit, 500, Ini.layoso, QueryTriggerInteraction.Ignore))
			{
				Debug.DrawLine(Ini.visaoLocal.position, Hit.point, Color.green);
				if (Hit.transform.gameObject.tag == "Player")
				{
					Ini.agent.destination = GameObject.FindWithTag("Player").transform.position;
				}

				else
				{
					if (Ini.agent.destination != Ini.Latspos)
					{
						Ini.Pratrulha();
					}
				}
			}
			else
			{
				if (Ini.agent.destination != Ini.Latspos)
				{
					Ini.Pratrulha();
				}
			}
		}
	}
}
