using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGrip : MonoBehaviour
{
    public Transform handTransform; // Transform of the hand
    public KeyCode gripKey = KeyCode.Space; // Key to press for gripping
    public float gripRadius = 0.5f; // Radius within which objects can be gripped
    public LayerMask grabbableLayer; // Layer of grabbable objects

    private FixedJoint fixedJoint;
    private Rigidbody grabbedObject;

    void Update()
    {
        if (Input.GetKeyDown(gripKey))
        {
            TryGrip();
        }
        if (Input.GetKeyUp(gripKey))
        {
            ReleaseGrip();
        }
    }

    void TryGrip()
    {
        Collider[] colliders = Physics.OverlapSphere(handTransform.position, gripRadius, grabbableLayer);
        if (colliders.Length > 0)
        {
            grabbedObject = colliders[0].GetComponent<Rigidbody>();
            if (grabbedObject != null)
            {
                fixedJoint = handTransform.gameObject.AddComponent<FixedJoint>();
                fixedJoint.connectedBody = grabbedObject;
            }
        }
    }

    void ReleaseGrip()
    {
        if (fixedJoint != null)
        {
            Destroy(fixedJoint);
            grabbedObject = null;
        }
    }
}