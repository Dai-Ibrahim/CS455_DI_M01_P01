//This script is in charge of the wander steering option
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KinematicWander : MonoBehaviour
{
    //Define all private variables
    private float maxSpeed = 0.1f;
    private float maxRotation = 50f;
    
    private Vector3 orientation;
    private Vector3 velocity = new Vector3(0, 0.1f, 0);

    private void Update()
    {

		transform.Rotate(0, RandomBinomial() * maxRotation, 0); //Rotate on the y axis to face a different random direction

		orientation = transform.forward * maxSpeed; //Go forwards
        transform.position += orientation; //update the position
    }
    //Define function that returns a random binomial float
    private float RandomBinomial()
    {
        return Random.value - Random.value;
    }
 
}
