using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnermyMovement : MonoBehaviour
{   
    private Rigidbody rb;//Access Modifer(Private) Component(Rigidbody) Name (rb) 
    
    // set move speed
    public float moveSpeed = 8f; //Access Modifer(Public) DataType(float) Name(moveSpeed) Value(8f)  
    
    // Start is called before the first frame update
    void Start()
    { 
        
        rb = GetComponent<Rigidbody>(); // Name(rb)  
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDirection = Vector3.forward; // Vector3 = (x,y,z) Name (moveDirection) moving car forward.
        rb.AddForce (moveDirection * moveSpeed);

    }
}
