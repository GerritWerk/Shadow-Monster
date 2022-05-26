using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractPorta : MonoBehaviour
{
    [SerializeField] bool Estado = true;
    [SerializeField] string NomeItemNecessario = "";
    [SerializeField] string AnimacaoFalso = "Fecha";
    [SerializeField] string AnimacaoVDD = "Abre";
    Animator animator;

    public void Action()
	{
        if (Estado)
            animator.SetTrigger(AnimacaoVDD);
        else
            animator.SetTrigger(AnimacaoFalso);
        Estado = !Estado;
	}
    // Start is called before the first frame update
    void Start()
    {
        animator = transform.root.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

