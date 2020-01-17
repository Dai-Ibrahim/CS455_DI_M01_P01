//The purpose of this script is to tell the game manager when a player has completed a level.
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
	public GameManager gameManager;
    void OnTriggerEnter()
    {
        gameManager.CompleteLevel(); //call completeLevel script
    }

}
