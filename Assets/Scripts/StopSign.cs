using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class StopSign : MonoBehaviour
{

 private bool carStopped;
 private HighScore highScore;

 private void Start()
 {
  highScore = GameObject.Find("Score").GetComponent<HighScore>();
 }

 private void OnTriggerStay(Collider other)
 {
  if (other.tag == "Car")
  {
   
    if (other.attachedRigidbody.velocity.magnitude * 3.6f <= 1f)
    {
     carStopped = true;
    }
  }
 }

 private void OnTriggerExit(Collider other)
 {
  if (!carStopped)
  {
   Debug.Log("The car didn't stop at the stop sign!");
   highScore.changeScore(-10);
  }
  else
  {
   Debug.Log("Car Stopped");
   highScore.changeScore(10);
  }

  carStopped = false;
 }

}

 

