using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearSwitch
{ 
    ICommand _onCommand;

    public GearSwitch(ICommand onCommand)
    {
        _onCommand = onCommand;
    }

    public void toggleGear()
    {
        _onCommand.Execute();
    }

}
