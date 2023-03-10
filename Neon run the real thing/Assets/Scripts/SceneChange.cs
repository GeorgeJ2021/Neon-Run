using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

	
	public void LoadGame()
	{
		SceneManager.LoadScene(1);
	}

	public void LoadGame2()
	{
		SceneManager.LoadScene(2);
	}

	public void QuitGame()
	{
		Application.Quit();
	}
}
