using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Jobs;

public class PlayerController : MonoBehaviour
{
  public float speed = 5.0f; // Created component named speed with a value of 5.
    public float turnSpeed;
    public float horizontalInput;
    public float verticalInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       
        horizontalInput = Input.GetAxis("Horizontal");
       

        transform.Translate(Vector3.forward * Time.deltaTime * speed);  // Moves the vechicle forward
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);

        //transform.Translate(Input.GetAxis("Horizontal"), 0, 0); //Move left and Right



    }
}
