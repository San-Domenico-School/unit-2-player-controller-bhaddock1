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
    private float speed;// holds foward movement of vehicle
    private float turnSpeed;
    private float verticalInput;
    private float horizantalInput;

    private Rigidbody rb;


    // initializes speed before first frame update
    void Start()
    {
        
        speed = 20.0f;// Constant speed of vehicle
        turnSpeed = 30.0f;
        rb = GetComponent<Rigidbody>();
   
    }

    // Updates vehicle postion per frame on Update
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);// position of vehicle ever frame update 

    }

    private void OnMove(InputValue input)
    {
        verticalInput = input.Get<Vector2>()
    }


}

