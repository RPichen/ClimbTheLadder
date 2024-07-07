using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public Transform LeftShoulder;
    public Transform LeftForearm;
    public Transform LeftHand;
    public Transform LeftHip;
    public Transform LeftCalf;
    public Transform LeftFoot;
    public Transform RightShoulder;
    public Transform RightForearm;
    public Transform RightHand;
    public Transform RightHip;
    public Transform RightCalf;
    public Transform RightFoot;
    public float limbRotationSpeed = 100.0f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Move();
        ControlLimbs();
    }

    void Move()
    {
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(0.0f, moveVertical, 0.0f);
        movement = movement.normalized * speed * Time.deltaTime;

        rb.MovePosition(transform.position + movement);
    }

    void ControlLimbs()
    {
        //LeftShoulder Controls
        if (Input.GetKey(KeyCode.U))
        {
            RotateLimb(LeftShoulder, Vector3.forward);
        }
        if (Input.GetKey(KeyCode.J))
        {
            RotateLimb(LeftShoulder, Vector3.back);
        }
        if (Input.GetKey(KeyCode.U))
        {
            RotateLimb(LeftShoulder, Vector3.up);
        }
        if (Input.GetKey(KeyCode.J))
        {
            RotateLimb(LeftShoulder, Vector3.down);
        }

        //LeftForearm Controls
        if (Input.GetKey(KeyCode.I))
        {
            RotateLimb(LeftForearm, Vector3.forward);
        }
        if (Input.GetKey(KeyCode.K))
        {
            RotateLimb(LeftForearm, Vector3.back);
        }
        if (Input.GetKey(KeyCode.I))
        {
            RotateLimb(LeftForearm, Vector3.up);
        }
        if (Input.GetKey(KeyCode.K))
        {
            RotateLimb(LeftForearm, Vector3.down);
        }


        //LeftHand Controls
        if (Input.GetKey(KeyCode.O))
        {
            RotateLimb(LeftHand, Vector3.forward);
        }
        if (Input.GetKey(KeyCode.L))
        {
            RotateLimb(LeftHand, Vector3.back);
        }
        if (Input.GetKey(KeyCode.O))
        {
            RotateLimb(LeftHand, Vector3.up);
        }
        if (Input.GetKey(KeyCode.L))
        {
            RotateLimb(LeftHand, Vector3.down);
        }

        //LeftHip Controls
        if (Input.GetKey(KeyCode.Y))
        {
            RotateLimb(LeftHip, Vector3.forward);
        }
        if (Input.GetKey(KeyCode.H))
        {
            RotateLimb(LeftHip, Vector3.back);
        }
        if (Input.GetKey(KeyCode.Y))
        {
            RotateLimb(LeftHip, Vector3.up);
        }
        if (Input.GetKey(KeyCode.H))
        {
            RotateLimb(LeftHip, Vector3.down);
        }

        //LeftCalf Controls
        if (Input.GetKey(KeyCode.G))
        {
            RotateLimb(LeftCalf, Vector3.forward);
        }
        if (Input.GetKey(KeyCode.T))
        {
            RotateLimb(LeftCalf, Vector3.back);
        }
        if (Input.GetKey(KeyCode.G))
        {
            RotateLimb(LeftCalf, Vector3.up);
        }
        if (Input.GetKey(KeyCode.T))
        {
            RotateLimb(LeftCalf, Vector3.down);
        }

        //LeftFoot Controls
        if (Input.GetKey(KeyCode.R))
        {
            RotateLimb(LeftFoot, Vector3.forward);
        }
        if (Input.GetKey(KeyCode.F))
        {
            RotateLimb(LeftFoot, Vector3.back);
        }
        if (Input.GetKey(KeyCode.R))
        {
            RotateLimb(LeftFoot, Vector3.up);
        }
        if (Input.GetKey(KeyCode.F))
        {
            RotateLimb(LeftFoot, Vector3.down);
        }

        //RightShoulder Controls
        if (Input.GetKey(KeyCode.P))
        {
            RotateLimb(RightShoulder, Vector3.forward);
        }
        if (Input.GetKey(KeyCode.Semicolon))
        {
            RotateLimb(RightShoulder, Vector3.back);
        }
        if (Input.GetKey(KeyCode.P))
        {
            RotateLimb(RightShoulder, Vector3.up);
        }
        if (Input.GetKey(KeyCode.Semicolon))
        {
            RotateLimb(RightShoulder, Vector3.down);
        }

        //RightForearm Controls
        if (Input.GetKey(KeyCode.LeftBracket))
        {
            RotateLimb(RightForearm, Vector3.forward);
        }
        if (Input.GetKey(KeyCode.Quote))
        {
            RotateLimb(RightForearm, Vector3.back);
        }
        if (Input.GetKey(KeyCode.LeftBracket))
        {
            RotateLimb(RightForearm, Vector3.up);
        }
        if (Input.GetKey(KeyCode.Quote))
        {
            RotateLimb(RightForearm, Vector3.down);
        }

        //RightHand Controls
        if (Input.GetKey(KeyCode.RightBracket))
        {
            RotateLimb(RightHand, Vector3.forward);
        }
        if (Input.GetKey(KeyCode.Backslash))
        {
            RotateLimb(RightHand, Vector3.back);
        }
        if (Input.GetKey(KeyCode.RightBracket))
        {
            RotateLimb(RightHand, Vector3.up);
        }
        if (Input.GetKey(KeyCode.Backslash))
        {
            RotateLimb(RightHand, Vector3.down);
        }

        //RightHip Controls
        if (Input.GetKey(KeyCode.L))
        {
            RotateLimb(RightHip, Vector3.forward);
        }
        if (Input.GetKey(KeyCode.Semicolon))
        {
            RotateLimb(RightHip, Vector3.back);
        }
        if (Input.GetKey(KeyCode.L))
        {
            RotateLimb(RightHip, Vector3.up);
        }
        if (Input.GetKey(KeyCode.Semicolon))
        {
            RotateLimb(RightHip, Vector3.down);
        }

        //RightCalf Controls
        if (Input.GetKey(KeyCode.K))
        {
            RotateLimb(RightCalf, Vector3.forward);
        }
        if (Input.GetKey(KeyCode.J))
        {
            RotateLimb(RightCalf, Vector3.back);
        }
        if (Input.GetKey(KeyCode.K))
        {
            RotateLimb(RightCalf, Vector3.up);
        }
        if (Input.GetKey(KeyCode.J))
        {
            RotateLimb(RightCalf, Vector3.down);
        }

        //RightFoot Controls
        if (Input.GetKey(KeyCode.H))
        {
            RotateLimb(RightFoot, Vector3.forward);
        }
        if (Input.GetKey(KeyCode.G))
        {
            RotateLimb(RightFoot, Vector3.back);
        }
        if (Input.GetKey(KeyCode.H))
        {
            RotateLimb(RightFoot, Vector3.up);
        }
        if (Input.GetKey(KeyCode.G))
        {
            RotateLimb(RightFoot, Vector3.down);
        }
    }

    void RotateLimb(Transform limb, Vector3 direction)
    {
        limb.Rotate(direction * limbRotationSpeed * Time.deltaTime);
    }
}