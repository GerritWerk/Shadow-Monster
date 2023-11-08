using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipalManeger : MonoBehaviour
{
	[SerializeField] private string NomeLevel;
	[SerializeField] private GameObject painelMenuInicial;
	[SerializeField] private GameObject painelOpcoes;

	[SerializeField] private GameObject painelCreditos;

	public void Update()
	{
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.Confined;
	}
	public void Jogar()
	{
		SceneManager.LoadScene(NomeLevel);
	}

  public void AbrirOpcoes()
	{
		painelMenuInicial.SetActive(false);
		painelOpcoes.SetActive(true);
	}
  public void FecharOpcoes()
	{
		painelOpcoes.SetActive(false);
		painelMenuInicial.SetActive(true);
	}

	public void AbrirCreditos(){
		painelMenuInicial.SetActive(false);
		painelCreditos.SetActive(true);
	}

	public void FecharCreditos(){
		painelCreditos.SetActive(false);
		painelMenuInicial.SetActive(true);
	}
  public void Sair()
	{
		//Debug.Log("Sair do Jogo");
		Application.Quit();
	}
}
