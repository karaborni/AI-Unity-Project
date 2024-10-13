using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target; // The target object to follow
    public Vector3 offset = new Vector3(0, 5, -10); // Desired offset

    void Start()
    {
        // Set the initial position of the camera based on the target and offset
        transform.position = target.position + offset;
    }

    void LateUpdate()
    {
        // Directly set the camera position based on target position plus offset
        transform.position = target.position + offset;

        // Debugging positions
        Debug.Log("Camera Position: " + transform.position);
        Debug.Log("Target Position: " + target.position);
    }
}
