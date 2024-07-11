using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollController : MonoBehaviour
{
    private Animator animator;
    private Rigidbody[] rigidbodies;
    private Collider[] colliders;
    public Rigidbody rootRigidbody; // Root rigidbody of the character (e.g., hips or pelvis)
    public Rigidbody[] limbRigidbodies; // Array of limb rigidbodies
    public float moveForce = 10f; // Force applied to move the character
    public float rotationTorque = 10f; // Torque applied to rotate the character
    public Transform cameraTarget; // Reference to the CameraTarget GameObject
    public Transform playerRoot;   // Reference to the player's root bone (e.g., hips)

    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbodies = GetComponentsInChildren<Rigidbody>();
        colliders = GetComponentsInChildren<Collider>();

        // Enable ragdoll on startup
        SetRagdollState(true);
    }

    void Update()
    {
        // Update the camera target position to follow the player's root
        if (cameraTarget != null && playerRoot != null)
        {
            cameraTarget.position = playerRoot.position;
        }

        HandleRagdollControl();
    }

    void HandleRagdollControl()
    {
        float moveY = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(0, 0, moveY).normalized;
        if (moveDirection.magnitude > 0.1f)
        {
            // Apply force to the root rigidbody to move the character
            rootRigidbody.AddForce(moveDirection * moveForce);

            // Apply torque to rotate the character
            Vector3 targetDirection = new Vector3(0, 0, moveY);
            Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
            rootRigidbody.MoveRotation(Quaternion.RotateTowards(rootRigidbody.rotation, targetRotation, rotationTorque * Time.deltaTime));
        }
    }

    public void SetRagdollState(bool isRagdoll)
    {
        animator.enabled = !isRagdoll;

        foreach (Rigidbody rb in rigidbodies)
        {
            rb.isKinematic = !isRagdoll;
        }

        foreach (Collider col in colliders)
        {
            col.enabled = isRagdoll;
        }

        foreach (Rigidbody rb in limbRigidbodies)
        {
            rb.isKinematic = !isRagdoll;
            rb.useGravity = isRagdoll;
        }

        if (rootRigidbody != null)
        {
            rootRigidbody.isKinematic = !isRagdoll;
            rootRigidbody.useGravity = isRagdoll;
        }

        // Add gravity to ragdoll
        foreach (Rigidbody rb in rigidbodies)
        {
            rb.useGravity = isRagdoll;
        }
        
    }
}
