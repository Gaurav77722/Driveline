using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] WheelCollider frontLeft;
    [SerializeField] WheelCollider frontRight;
    [SerializeField] WheelCollider backLeft;
    [SerializeField] WheelCollider backRight;

    public float acceleration = 500f;
    public float breakingForce = 300f;
    public float maxTurnAngle = 10f;
    
    private float currentAcceleration = 0f;
    private float currentBreakingForce = 0f;
    private float currentTurnAngle = 0f;

    private int currentMovementValue = 0;

    private void FixedUpdate()
    {
        // W to toggle car in forward direction and S to toggle Car in reverse direction
        if (Input.GetKey(KeyCode.W))
        {
            currentMovementValue = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            currentMovementValue = -1;
        }
        
        // Accelerate Car
        if (Input.GetKey(KeyCode.Space))
        {
            currentAcceleration = acceleration * currentMovementValue;
        }
        else
        {
            currentAcceleration = 0f;
            rb.velocity *= 0.99f;
        }
        
        
        // Brake
        if (Input.GetKey(KeyCode.B))
        {
            currentBreakingForce = breakingForce;
            currentAcceleration = 0f;
        }
        else
        {
            currentBreakingForce = 0f;
        }
        
        // Acceleration for front wheels
        frontRight.motorTorque = currentAcceleration;
        frontLeft.motorTorque = currentAcceleration;

        frontRight.brakeTorque = currentBreakingForce;
        frontLeft.brakeTorque = currentBreakingForce;
        backLeft.brakeTorque = currentBreakingForce;
        backRight.brakeTorque = currentBreakingForce;
        
        // Turning the car using A and D
        currentTurnAngle = maxTurnAngle * Input.GetAxis("Horizontal");
        frontLeft.steerAngle = currentTurnAngle;
        frontRight.steerAngle = currentTurnAngle;
    }
}
