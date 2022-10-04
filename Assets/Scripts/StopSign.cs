using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopSign : MonoBehaviour
{
 private bool carStopped = false;
 private void OnTriggerStay(Collider other)
 {
  if (other.tag == "Car")
  {
   if (other.attachedRigidbody.velocity.magnitude*3.6f <= 1f)
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
  }
  else
  {
   Debug.Log("Car Stopped!");
  }
 }
}
