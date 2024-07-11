using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimbController : MonoBehaviour
{
    // Arms
    public Rigidbody LeftArm;
    public Rigidbody RightArm;

    // Legs
    public Rigidbody LeftLeg;
    public Rigidbody RightLeg;
    
    public float force = 10f;

    void Update()
    {
        // Left arm control
        if (Input.GetKey(KeyCode.Q))
        {
            ApplyForce(LeftArm);
        }

        // Right arm control
        if (Input.GetKey(KeyCode.W))
        {
            ApplyForce(RightArm);
        }

        // Left leg control
        if (Input.GetKey(KeyCode.O))
        {
            ApplyForce(LeftLeg);
        }

        // Right leg control
        if (Input.GetKey(KeyCode.P))
        {
            ApplyForce(RightLeg);
        }
    }

    void ApplyForce(Rigidbody limb)
    {
        if (limb != null)
        {
            limb.AddForce(Vector3.up * force);
        }
    }
}