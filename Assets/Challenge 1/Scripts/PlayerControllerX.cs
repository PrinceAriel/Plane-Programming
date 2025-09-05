using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 5f;  // Reduced from 20f to 5f for manageable speed
    public float rotationSpeed = 30f;  // Also reduced rotation speed slightly
    public float verticalInput;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        // Move the plane forward constantly
        transform.Translate(Vector3.forward * speed * Time.fixedDeltaTime);

        // Only rotate if keys are actually pressed
        if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed)
        {
            // Pitch up
            transform.Rotate(Vector3.right * rotationSpeed * Time.fixedDeltaTime);
        }
        else if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed)
        {
            // Pitch down
            transform.Rotate(Vector3.right * -rotationSpeed * Time.fixedDeltaTime);
        }
        // If no keys pressed, no rotation happens - plane stays level
    }
}
