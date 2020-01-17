//The purpose of this script is to manage event handeling for the scenes in the game.  
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	bool GameHasEnded = false;
	public float restartDelay = 1f;
	
	public GameObject completeLevelUI;
    public void EndGame()
    {
        if (GameHasEnded == false)
		{
			GameHasEnded = true;
			Invoke("Restart", restartDelay);
		}
    }
	public void CompleteLevel()
	{
		completeLevelUI.SetActive(true); 
	}
	void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
