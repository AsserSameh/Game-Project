using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //private varibales
    private float speed = 20;
    private float turnSpeed = 25;
    private float HorizontalInput;
    private float forwardInput;
    void Update()
    {
        //this where we get player input
        HorizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
       //moves the car forward base on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed *forwardInput);
        //moves the car forward base on horizantal input
        transform.Rotate(Vector3.up, turnSpeed *HorizontalInput * Time.deltaTime);

    }
}
