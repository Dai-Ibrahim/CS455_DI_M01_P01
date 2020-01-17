//This script implements the smoothing function in the text book
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smooth : MonoBehaviour
{
	//Define all variables
    Vector3 position;
    Vector3 velocity;
    Vector3 linear;
	float orientation;
	float rotation;
    float angular = 0.1f;
    float half_t_sq;
    float maxSpeed = 5f;

    private void Start()
    {
        velocity = transform.forward * maxSpeed; //Set velocity 
    }

    private void Update()
    {
        linear = transform.forward * maxSpeed; // Set linear velocity
        orientation = transform.rotation.y; //Change orientation by rotaing on the y axis
        half_t_sq = (float)0.5 * Time.deltaTime * Time.deltaTime; //equation for motion
        transform.position += velocity * Time.deltaTime + linear * half_t_sq;
        transform.rotation *= new Quaternion(0, 0, rotation * Time.deltaTime + angular * half_t_sq, 0);//apply the new rotation
		// Update velocity and rotation
        velocity += linear * Time.deltaTime;
        rotation += angular * Time.deltaTime;
    }
}