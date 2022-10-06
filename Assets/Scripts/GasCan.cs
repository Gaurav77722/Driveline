using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasCan : MonoBehaviour
{
    public GameObject gasCan;

    private void OnMouseDown()
    { 
        if (gameObject.CompareTag("gasCan"))
        {
            Destroy(gameObject);
        }
    }
}
