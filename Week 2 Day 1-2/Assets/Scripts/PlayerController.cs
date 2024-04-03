using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Jobs;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f; // Created component named speed with a value of 5.
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the vechicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        //Move left and Right
        transform.Translate(Input.GetAxis("Horizontal"), 0, 0);

       

    }
}
