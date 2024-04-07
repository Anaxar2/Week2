using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Jobs;

public class PlayerController1 : MonoBehaviour
{
    public float speed = 5f; // Created component named speed with a value of 5.
    public float turnSpeed = 1f;
    float horizontalInput;
    float forwardInput;
    float currentTurnSpeed;

    public string inputName;
    
    // Start is called before the first frame update
    void Start()
    {
        currentTurnSpeed = turnSpeed;
    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal" + inputName);

        forwardInput = Input.GetAxis("Vertical" + inputName);

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);  // Moves the vechicle forward based on vertical input.
      
        if(forwardInput != 0)//cheking input in the y or forward axis.
        {
          transform.Rotate(Vector3.up, turnSpeed * horizontalInput); // Rotates player based on horizontal input (left and right).
        }
        if (forwardInput < 0) //checking input in the -y or backward axis.

        {
            turnSpeed = -currentTurnSpeed;  //Inverse Rotation when going back.
        }
        if(forwardInput > 0)
        {
            turnSpeed = currentTurnSpeed;
        }
    }
}
