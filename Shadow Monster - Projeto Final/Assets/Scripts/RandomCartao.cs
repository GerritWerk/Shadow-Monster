using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCartao : MonoBehaviour
{

    public Transform[] posicaoCartao;
    public GameObject Cartao;
    // Start is called before the first frame update
    void Start()
    {
     int posicaoEscolhida = Random.Range(0, posicaoCartao.Length);

        Instantiate(Cartao, posicaoCartao[posicaoEscolhida].position, Quaternion.identity);
    }
    

    
}
