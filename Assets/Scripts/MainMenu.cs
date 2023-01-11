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
		//SceneManager.LoadScene(Medium);
		Debug.Log("Medium");
	}
	
	public void Hard()
	{
		//SceneManager.LoadScene(Hard);
		Debug.Log("Hard");
	}

	public void ReadMe()
    {
		//SceneManager.LoadScene(ReadMe);
    }

	public void QuitGame()
	{
		Debug.Log("Quit");
		Application.Quit();
	}
}
