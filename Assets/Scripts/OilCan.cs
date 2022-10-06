using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilCan : MonoBehaviour
{
    public GameObject oilCan;

    private void OnMouseDown()
    { 
        if (gameObject.CompareTag("oilCan"))
        {
            Destroy(gameObject);
        }
    }
}
