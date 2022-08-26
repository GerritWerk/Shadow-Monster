using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipalManeger : MonoBehaviour
{
	[SerializeField] private string NomeLevel;
	[SerializeField] private GameObject painelMenuInicial;
	[SerializeField] private GameObject painelOpcoes;
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
  public void Sair()
	{
		Debug.Log("Sair do Jogo");
		Application.Quit();
	}
}