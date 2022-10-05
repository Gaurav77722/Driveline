using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FuelSystem : MonoBehaviour
{
    public float currentFuel = 100f;
    public TextMeshProUGUI fuelText;
    public float gameTick = 1f;
    float timeAccumulated;
    //bool carIsMoving;

    public void Update()
    {
        UpdateFuel();
    }
    private void UpdateFuel(){
        timeAccumulated += Time.deltaTime;

        if(timeAccumulated > gameTick){
            if(currentFuel> 0){
                currentFuel -= 1f;
                timeAccumulated = 0f;
            }
            else{
                currentFuel -= 0;
            }
            fuelText.text = currentFuel.ToString();
        }
    }
    private void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "fuel")
        {
            currentFuel = 100f;
        }
    }
}
