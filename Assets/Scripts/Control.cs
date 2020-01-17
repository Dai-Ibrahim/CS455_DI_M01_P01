//This script controls the menu button press to go the AI Demo
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class Control : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("AiBit"); // load the scene AiBit
    }
}