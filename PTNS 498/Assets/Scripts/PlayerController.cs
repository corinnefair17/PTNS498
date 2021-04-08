using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Handles collisions and physics for 2D characters
    Rigidbody2D body;

    // Track which keys are being pressed on the keyboard
    float horizontal;
    float vertical;

    // Controls movement speed
    public float movementSpeed = 20.0f;

    // A variable to be used to slow down diagonal movement
    float moveLimiter = 0.7f;

    // Initialize body and attach it to player sprite
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Updates upon each frame load
    void Update()
    {
        // These values will return either 1 or -1 for direction
        // 0 is no movement
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    // Updates whenever physics calculations are needed
    void FixedUpdate()
    {
        // Prevent diagonal movement from being too fast
        if (horizontal != 0 && vertical != 0)
        {
            horizontal *= moveLimiter;
            vertical *= moveLimiter;
        }

        // Set the player's movement to input direction at given movement speed
        body.velocity = new Vector2(horizontal * movementSpeed, vertical * movementSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collider) 
    {
        Debug.Log("Trigger Hit");
    }
}
