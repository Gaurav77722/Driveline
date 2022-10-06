using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasDepletion : MonoBehaviour
{
    private Rigidbody2D _rb;
    public float fuel = 100f;
    public float maxFuel = 200f;
    public float speed = 3f;
    public float fuelLostPerTick = 2f;
    public CarScript car; //Edit here 
    
    public float gameTick = 2f;

    // Time management
    private float _timeAccumulated;
    private float _countDownAccumulated;
    public float timeLeft = 200f;
    
    // Start is called before the first frame update
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
    
    private void UpdateTimer()
    {
        _countDownAccumulated += Time.deltaTime;

        if (_countDownAccumulated > 0.01f)
        {
            timeLeft -= 0.01f;
            _countDownAccumulated = 0f;
        }
    }
    
    private void UpdateFuel()
    {
        _timeAccumulated += Time.deltaTime;

        if (_timeAccumulated > gameTick) // Edit here
        {
            if (car.fuel > 0)
            {
                car.fuel -= car.fuelLostPerTick;
                _timeAccumulated = 0f;
            }
            else
            {
                car.fuel = 0;
            }
        }
    }
}
