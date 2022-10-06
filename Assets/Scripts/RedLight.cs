using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedLight : MonoBehaviour
{
    private Light[] TL1Lights;
    private HighScore highScore;
    void Start()
    {
        TL1Lights = GetComponentsInChildren<Light>();
        highScore = GameObject.Find("Score").GetComponent<HighScore>();
    }

    private void OnTriggerExit(Collider other)
    {
        if ((other.tag == "Car") && (TL1Lights[0].intensity == 1000 ))
        {
            Debug.Log("You crossed a red light!");
            highScore.changeScore(-10);
        }
        else if ((other.tag == "Car") && (TL1Lights[1].intensity == 1000))
        {
            Debug.Log("Green Light!");
            highScore.changeScore(10);
        }
    }
}
