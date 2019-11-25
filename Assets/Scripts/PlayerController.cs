using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    public float drag = 0.5f;
    public float terminalRotationSpeed = 25.0f;
    public Vector3 MoveVector { set; get; }
    public VirtualJoystick joystick;
    private Rigidbody thisRigidbody;
   
    void Start()
    {
        thisRigidbody = gameObject.GetComponent<Rigidbody>();
        thisRigidbody.maxAngularVelocity = terminalRotationSpeed;
        thisRigidbody.drag = drag;
    }

    void Update()
    {
        MoveVector = PoolInput();
        Move();
    }

    private void Move()
    {
        thisRigidbody.AddForce(MoveVector * moveSpeed);
    }

    private Vector3 PoolInput()
    {
        Vector3 dir = Vector3.zero;

        dir.x = joystick.Horizontal();
        dir.z = joystick.Vertical();

        if (dir.magnitude > 1)
            dir.Normalize();

        return dir;
    }
}
