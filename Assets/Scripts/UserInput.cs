using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{

    public WheelController _wheelController;
    GearSwitch _gearSwitch;

    void Start()
    {
        ICommand toggleGearCommand = new ToggleGearCommand(_wheelController);
        _gearSwitch = new GearSwitch(toggleGearCommand);
    }

    // Update is called once per frame
    void Update()
    {
        // Toggle Car forward and backward using W using the command pattern
        if (Input.GetKeyDown(KeyCode.W))
        {
            _gearSwitch.toggleGear();
        }

        // Accelerate car using Space
        if (Input.GetKey(KeyCode.Space))
        {
            _wheelController.accelerateCar();
        }
        else
        {
            _wheelController.decelerateCar();
        }

        // Apply brakes using left control
        if (Input.GetKey(KeyCode.LeftControl))
        {
            _wheelController.Brake();
        }
        else
        {
            _wheelController.resetBrakeForce();
        }


    }
}
