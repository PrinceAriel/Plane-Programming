using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(10, 2, 0); // Camera positioned to the right side of the plane

    void Start()
    {
        if (plane == null)
        {
            Debug.LogError("Plane not assigned to FollowPlayerX script!");
            return;
        }
        
        // Use the preset offset instead of calculating from current position
        // This ensures camera is always beside the plane
    }

    void LateUpdate()
    {
        if (plane != null)
        {
            transform.position = plane.transform.position + offset;
            
            // Optional: Make camera look at the plane
            transform.LookAt(plane.transform);
        }
    }
}