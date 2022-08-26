using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGameManeger : MonoBehaviour
{
	[SerializeField] private string NomeLevel;
	[SerializeField] private GameObject Menu;
	public void Voltar()
	{
		Menu.SetActive(false);
		Cursor.visible = false;
		Time.timeScale = 1;
	}

	public void Sair()
	{
		SceneManager.LoadScene(NomeLevel);
	}
}
