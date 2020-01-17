//This script handles what happens when a player collides with an obstacle
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
	public PlayerMovement movement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle") // check the tag of what the player collided with
		{
			movement.enabled = false; // disable motion
			FindObjectOfType<GameManager>().EndGame(); //call the EndGame script that will reload the level

		}
    }


}
