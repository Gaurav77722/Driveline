using UnityEngine;


public class TrafficController : MonoBehaviour
{
    private GameObject TrafficLight1;
    private GameObject TrafficLight2;
    private GameObject TrafficLight3;
    private GameObject TrafficLight4;
    private Light[] TL1Lights;
    private Light[] TL2Lights;
    private Light[] TL3Lights;
    private Light[] TL4Lights;

    private float timer = 40;

    private bool flag1 = false;
    private bool flag2 = false;
    private bool flag3 = false;
    private bool flag4 = false;



    public int maxTimer = 40;
    public int interval = 10;



    // Start is called before the first frame update
    void Start()
    {
        TrafficLight1 = GameObject.FindWithTag("TL1");
        TrafficLight2 = GameObject.FindWithTag("TL2");
        TrafficLight3 = GameObject.FindWithTag("TL3");
        TrafficLight4 = GameObject.FindWithTag("TL4");

        TL1Lights = TrafficLight1.GetComponentsInChildren<Light>();
        TL2Lights = TrafficLight2.GetComponentsInChildren<Light>();
        TL3Lights = TrafficLight3.GetComponentsInChildren<Light>();
        TL4Lights = TrafficLight4.GetComponentsInChildren<Light>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        TL1Lights[1].intensity = 1000;
        TL2Lights[1].intensity = 1000;
        TL3Lights[1].intensity = 1000;
        TL4Lights[1].intensity = 1000;

        if (TL1Lights[0].intensity == 1000)
        {
            TL1Lights[1].intensity = 1;
        }

        if (TL2Lights[0].intensity == 1000)
        {
            TL2Lights[1].intensity = 1;
        }

        if (TL3Lights[0].intensity == 1000)
        {
            TL3Lights[1].intensity = 1;
        }

        if (TL4Lights[0].intensity == 1000)
        {
            TL4Lights[1].intensity = 1;
        }
        


        timer -= Time.deltaTime;
        if (timer < 2f)
        {
            timer = 39f;
            flag1 = false;
            flag2 = false;
            flag3 = false;
            flag4 = false;
        }

        trafficInterval(40, 10, timer);

    }

    void trafficInterval(int maxTimer, int interval, float timer)
    {
        if (timer <= maxTimer && timer > (maxTimer - interval) && flag1 == false)
        {
            TL1Lights[0].intensity = 1000;

            if (timer <= (maxTimer - interval + 1) && timer > (maxTimer - interval))
            {
                TL1Lights[0].intensity = 1;
                flag1 = true;

            }
        }
        
        if (timer <= (maxTimer - interval) && timer > (maxTimer - (2 * interval)) && flag2 == false)
        {
            TL2Lights[0].intensity = 1000;
            if (timer <= (maxTimer - (2 * interval) + 1) && timer > (maxTimer - (2 * interval)))
            {
                TL2Lights[0].intensity = 1;
                flag2 = true;
            }
        }
        

        if (timer <= (maxTimer - (2 * interval)) && timer > (maxTimer - (3 * interval)) && flag3 == false)
        {
            TL3Lights[0].intensity = 1000;
            if (timer <= (maxTimer - (3 * interval) + 1) && timer > (maxTimer - (3 * interval)))
            {
                TL3Lights[0].intensity = 1;
                flag3 = true;
            }
        }
        

        if (timer <= (maxTimer - (3 * interval)) && flag4 == false)
        {
            TL4Lights[0].intensity = 1000;
            if (timer <= (maxTimer - (4 * interval) + 1))
            {
                TL4Lights[0].intensity = 1;
                flag4 = true;
            }
        }
    }
}
