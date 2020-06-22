using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
	public string sceneName;

	void OnTriggerEnter2D(Collider2D other)
	{
		SceneManager.LoadScene (sceneName);
	}
}
