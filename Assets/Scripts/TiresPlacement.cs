using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiresPlacement : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject frontleftWheel;
    public GameObject frontrightWheel;
    public GameObject backleftWheel;
    public GameObject backrightWheel;
    

    private void OnMouseDown()
    { 
        if (gameObject.CompareTag("FLWheel"))
        {
            Quaternion frontleftWheel = Quaternion.Euler(0,0,0);
            transform.position = new Vector3(-0.096f, 0.469f, 2.807f);
            
        }
        if (gameObject.CompareTag("FRWheel"))
        {
            transform.position = new Vector3(-1.12410748f, 0.458328009f, 1.91500831f);
            Destroy(gameObject);
        }
        if (gameObject.CompareTag("BLWheel"))
        {
            Quaternion backleftWheel = Quaternion.Euler(0,0,0);
            transform.position = new Vector3(-0.0387f, 0.453f, -0.849f);
        }
        if (gameObject.CompareTag("BRWheel"))
        {
            Destroy(gameObject);
        }
    }
}
