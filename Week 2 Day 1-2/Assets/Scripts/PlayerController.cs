using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Jobs;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f; // Created component named speed with a value of 5.
    public float turnSpeed = 1f;
    float horizontalInput;
    float forwardInput;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
      
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);  // Moves the vechicle forward based on vertical input.
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput); // Rotates player based on horizontal input (left and right).



    }
}
