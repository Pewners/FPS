using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public void Easy()
	{
		SceneManager.LoadScene(1);
	}
	
	public void Medium()
	{
		SceneManager.LoadScene(2);
	}
	
	public void Hard()
	{
		SceneManager.LoadScene(3);
	}

	public void Menu()
    {
		SceneManager.LoadScene(0);
	}

	public void QuitGame()
	{
		Debug.Log("Quit");
		Application.Quit();
	}
}
