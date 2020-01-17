//This script handles the score in the level
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	//Define all public variables
	public Transform player;
	public Text scoreText;
	
    void Update()
    {
        scoreText.text = player.position.z.ToString("0"); // set the score to be the player's z position and update the string
    }
}
