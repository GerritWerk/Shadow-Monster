using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanterna : MonoBehaviour
{
    public Light lanterna;
    public float tempoMinimoLigada = 0.5f;
    public float tempoMaximoLigada = 3.0f;
    public float tempoMinimoDesligada = 0.5f;
    public float tempoMaximoDesligada = 3.0f;

    private bool ligada = false;
    // Start is called before the first frame update
    void Start()
    {
         StartCoroutine(GerenciarLanterna());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator GerenciarLanterna(){
        
        while(true){
            if(ligada){
                lanterna.enabled = false;
                ligada = false;
                float tempoDesligado = Random.Range(tempoMinimoDesligada,tempoMaximoDesligada);
                yield return new WaitForSeconds(tempoDesligado);
            }
            else{
                 lanterna.enabled = true;
                ligada = true;
                float tempoLigado = Random.Range(tempoMinimoLigada,tempoMaximoLigada);
                yield return new WaitForSeconds(tempoLigado);
            }
        }
    }
}
