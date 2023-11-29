using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGameManeger : MonoBehaviour
{
	[SerializeField] private string NomeLevel;
	[SerializeField] private GameObject Menu;
	//private Player player;
	public void Voltar()
	{
		Menu.SetActive(false);
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		Time.timeScale = 1;
		//player.Lan.Play();
	}

	public void Sair()
	{
		SceneManager.LoadScene(NomeLevel);
	}
}
