using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleGearCommand : ICommand
{
    WheelController _wheelController;
    public ToggleGearCommand(WheelController wheelController)
    {
        _wheelController = wheelController;
    }
    
    public void Execute()
    {
        _wheelController.toggleCarGear();
    }
    
    
}
