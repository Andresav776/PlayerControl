using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 25.0f;
    private float turnSpeed = 75.0f;
    private float horizontalInput;
    private float forwardInput;

    public Camera firstPerson;
    public Camera thirdPerson;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Moves the Vehicle Forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Turns the vehicle
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime); 

        if(Input.GetKeyDown(KeyCode.Space))
        {
            thirdPerson.enabled = !thirdPerson.enabled;
            firstPerson.enabled = !firstPerson.enabled;
        }
    }
}
