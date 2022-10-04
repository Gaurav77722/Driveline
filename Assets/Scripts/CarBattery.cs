using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarBattery : MonoBehaviour
{
    public GameObject carBattery;

    private void OnMouseDown()
    { 
        if (gameObject.CompareTag("carBattery"))
        {
            Destroy(gameObject);
        }
    }
}
