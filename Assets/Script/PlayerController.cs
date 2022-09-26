using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // private variables
    private float speed = 15f;
    private float turnSpeed = 35f;
    private float horizontalInput;
    private float verticalInput;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // this is where user input is added
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");


        // this is where i move the vechicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        // this is where the vechicle move sideways
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
        
    }
}
