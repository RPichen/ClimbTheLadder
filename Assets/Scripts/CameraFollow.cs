using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Reference to the player transform
    public Vector3 offset = new Vector3(0, 2, -5); // Offset from the player position
    public float smoothSpeed = 0.125f; // Smoothing speed for the camera movement

    void LateUpdate()
    {
        if (player == null) return; // Ensure player is assigned

        // Calculate the desired position based on the player's vertical position
        Vector3 desiredPosition = new Vector3(transform.position.x, player.position.y + offset.y, player.position.z + offset.z);
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        // Keep the camera looking at the player without rotating
        transform.LookAt(player);
    }
}