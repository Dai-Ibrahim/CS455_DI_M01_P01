//This script handles the cubethon game movements
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Define all public variables 
	public Rigidbody rb;
   	public float forwardsForce = 2000f;
	public float sidwaysForce = 500f;

    // Update is called once per frame
    void FixedUpdate()
    {
		//Add a forward force on the object 
        rb.AddForce(0,0,forwardsForce*Time.deltaTime);
		
		//Get user input and move object accordingly
		if (Input.GetKey("d"))
		{
			rb.AddForce(sidwaysForce*Time.deltaTime,0,0, ForceMode.VelocityChange);
		}
		if (Input.GetKey("a"))
		{
			rb.AddForce(-sidwaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
		}
		//End game if the object falls off the platform
		if (rb.position.y < -1f)
		{
			FindObjectOfType<GameManager>().EndGame();

		}

    }
}

