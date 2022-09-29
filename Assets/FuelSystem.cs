using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelSystem : MonoBehaviour
{
    public Text Fueltext;
    public Image FuelImage;

    public float CurrentTime = 5;
    public float MaxTime = 5;

    void FixedUpdate()
    {
        UpdateUI();
        

        
    }
    public void UpdateUI()
        {
        //FuelImage.fillAmount = CurrentTime/MaxTime ;
        //Fueltext.text = "Fuel: " + (CurrentTime/MaxTime * 100).ToString();
        }
    private void LateUpdate()
    {
        
    }
}
