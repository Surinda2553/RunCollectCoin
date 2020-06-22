using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MControler : MonoBehaviour
{
	public void LoadScene (string sceneName)
	{
		SceneManager.LoadScene(sceneName);
	}
	public void ExitGame()
	{
		Application.Quit();
	}
}