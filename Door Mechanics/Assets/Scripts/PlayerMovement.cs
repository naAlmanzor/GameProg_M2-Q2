using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float movementSpeed;
    public float groundDrag;
    
    public Transform orientation;

    float horizontalInput;
    float verticalInput;

    Vector3 movementDirection;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerInput(); 
        // SpeedControl();
        rb.drag = groundDrag;   
    }

    void FixedUpdate(){
        MovePlayer();
    }

    void PlayerInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    void MovePlayer()
    {
        movementDirection = (orientation.forward * verticalInput) + (orientation.right * horizontalInput); 
        rb.AddForce(movementDirection.normalized*movementSpeed*10f, ForceMode.Force);
    }

    void SpeedControl()
    {
        Vector3 flatVelocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
        if(flatVelocity.magnitude>movementSpeed)
        {
            Vector3 limitVelocity = flatVelocity.normalized*movementSpeed;
            rb.velocity = new Vector3(limitVelocity.x, rb.velocity.y, limitVelocity.z);
        }
    }

}
