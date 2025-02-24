using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; 
    public float rotationSpeed = 700f;

    private Rigidbody rb;
    private Vector3 moveDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

       
        if (rb != null)
        {
            rb.freezeRotation = true;
        }
    }

    void Update()
    {
        HandleMovement();
    }

    void HandleMovement()
    {
       
        float horizontal = Input.GetAxis("Horizontal"); 
        float vertical = Input.GetAxis("Vertical"); 

        moveDirection = new Vector3(horizontal, 0f, vertical).normalized;

      
        if (moveDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(moveDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }


        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}
