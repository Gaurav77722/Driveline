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
    
    [SerializeField] Transform frontLeftTransform;
    [SerializeField] Transform frontRightTransform;
    [SerializeField] Transform backLeftTransform;
    [SerializeField] Transform backRightTransform;

    public float acceleration = 500f;
    public float breakingForce = 300f;
    public float maxTurnAngle = 10f;
    
    public float currentAcceleration = 0f;
    public float currentBreakingForce = 0f;
    public float currentTurnAngle = 0f;

    private int currentMovementValue = 0;

    private bool Gear = false;

    private void FixedUpdate()
    {
        
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
        
        // Update position of wheel meshes
        UpdateWheelMesh(backLeft, backLeftTransform);
        UpdateWheelMesh(frontLeft, frontLeftTransform);
        UpdateWheelMesh(backRight, backRightTransform);
        UpdateWheelMesh(frontRight, frontRightTransform);
    }

    void UpdateWheelMesh(WheelCollider wheel, Transform meshTransform)
    {
        // Get the position of the wheelCollider in the world
        Vector3 position;
        Quaternion rotation;
        wheel.GetWorldPose(out position, out rotation);
        
        // Set the position of the mesh
        meshTransform.position = position;
        meshTransform.rotation = rotation;
    }

    public void accelerateCar()
    {
        currentAcceleration = acceleration * currentMovementValue;
    }

    public void decelerateCar()
    {
        currentAcceleration = 0f;
        rb.velocity *= 0.99f;
    }

    public void toggleCarGear()
    {
        if (Gear == false)
        {
            currentMovementValue = 1;
            Gear = true;
        }
        else if(Gear)
        {
            currentMovementValue = -1;
            Gear = false;
        }
    }
    

    public void Brake()
    {
        currentBreakingForce = breakingForce;
        currentAcceleration = 0f;
    }

    public void resetBrakeForce()
    {
        currentBreakingForce = 0f;
    }
    
}
