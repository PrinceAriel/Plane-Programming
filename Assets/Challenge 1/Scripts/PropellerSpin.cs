using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    public float spinSpeed = 1000f; // Speed of propeller rotation (degrees per second)

    void Update()
    {
        // Spin the propeller around its forward axis (Z-axis)
        transform.Rotate(0, 0, spinSpeed * Time.deltaTime);
    }
}