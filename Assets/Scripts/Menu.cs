// This script is used to move from scene to scene after a level is completed.
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame()
    {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // load the next scene in the list

    }

}
