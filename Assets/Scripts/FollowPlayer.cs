//This script handles the camera following the player
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
	public Transform player;
	public Vector3 offset; // offset the camera from the player position
    void Update()
    {
        transform.position=player.position + offset; // get the new camera position
    }
}
