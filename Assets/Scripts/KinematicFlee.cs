//This script handles the flee stering option
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KinematicFlee : MonoBehaviour
{
	//Define all public variables
    public float maxSpeed = 5f;
	public Transform enemy;
	public Transform target;
	public float radius = 4.0f;
    //Define class that includes the velocity and rotation attributes
	public class SteeringOutput 
	{
		public Vector3 velocity;
		public float rotation;

	}
    
    void Update()
    {
     SteeringOutput dingus = getSteering(); //create a variable that will have attributes velocity and rotation
	 enemy.transform.position -= dingus.velocity*Time.deltaTime; //set the position to move away from the enemy 	
    }
	//This function controls the motion of the object
	SteeringOutput getSteering()
	{   
		SteeringOutput result = new SteeringOutput(); // create the variable that will be used to return the new attributes
		result.velocity = target.position - enemy.position; // flee
		if (result.velocity.magnitude < radius) //Arrive is implemented here, if the object is in the arrival radius
		{
			result.velocity *= 0; // set velocity to 0
			result.rotation = 0f; // set rotation to 0
			return result;
		}
		else // continue as normal
		{
		result.velocity.Normalize();
		result.velocity *= maxSpeed;
		
		float angleDeg = newOrientation(enemy.transform.eulerAngles.y, result.velocity); //get a new orientation
		angleDeg *= Mathf.Rad2Deg; // convert to degrees
		enemy.transform.eulerAngles = new Vector3 (0,angleDeg,0); //use the angle to create a new rotation vector
		result.rotation = 0;
		return result;
		}
		
	}
	// this function returns a new value for y rotation
	float newOrientation(float current , Vector3 velocity)
	{
		
		if (velocity.magnitude > 0)
			{
				return Mathf.Atan2(velocity.x, velocity.z); // result is in radians
			}
			else
			{
				return current;
			}
	}

}

