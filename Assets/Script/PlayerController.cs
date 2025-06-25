using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5.0f;
    private float turnSpeed = 25f;
    private float horizontalInput;
    private float forwardInput;

    void Update()
    {
        //getting the player's input 
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Move vehicle Forward and Backward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Turn vehical to right and left 
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
