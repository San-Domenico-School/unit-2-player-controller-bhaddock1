using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/********************************************
 * Component of vehicle that moves it at a constant speed forward
 * 
 * Bryce Haddock
 * Spetember 12, 2023 Version 1.0
 *******************************************/

public class PlayerController : MonoBehaviour
{
    private float speed;                // holds foward movement of vehicle
    private float turnSpeed;            // holds the turn speed of the vehicle
    private float verticalInput;        // gets a value [-1,1] from user key press up/down W/S
    private float horizantalInput;      // gets a value [-1,1] from user key press left/right A/D

    private Rigidbody rb;               // points to vehicle rigid body component


    // initializes speed and turn speed before first frame update
    void Start()
    {
        
        speed = 3000.0f;                      // Constant speed of vehicle
        turnSpeed = 30.0f;                  // turn speed of vehicle
        rb = GetComponent<Rigidbody>();     // short cut to rigidbody
   
    }

    // Updates vehicle postion per frame on Update
    void FixedUpdate()
    {
        rb.AddRelativeForce(Vector3.forward * speed * verticalInput);
        transform.Rotate(Vector3.up * turnSpeed * horizantalInput * Time.deltaTime);

    }
    // Updates movements of vehicle on keypress WASD
    private void OnMove(InputValue input)
    {
        verticalInput = input.Get<Vector2>().y;
        horizantalInput = input.Get<Vector2>().x;
    }


}

