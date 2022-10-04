using UnityEngine;


public class TrafficController : MonoBehaviour
{
    private GameObject TrafficLight1;
    private GameObject TrafficLight2;
    private GameObject TrafficLight3;
    private GameObject TrafficLight4;
    private Light [] TL1Lights;
    private Light [] TL2Lights;
    private Light [] TL3Lights;
    private Light [] TL4Lights;

    private float timer = 40;

    private bool flag1 = false;
    private bool flag2 = false;
    private bool flag3 = false;
    private bool flag4 = false;
    

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
        
        // StartCoroutine(increaseIntensity(TL1Lights));
        // StopCoroutine(increaseIntensity(TL1Lights));
        // StartCoroutine(increaseIntensity(TL2Lights));
        // StartCoroutine(increaseIntensity(TL3Lights));
        // StartCoroutine(increaseIntensity(TL4Lights));

        Debug.Log(timer);
        if (timer <= 40 && timer > 30 && flag1 == false)
        {
            TL1Lights[0].intensity = 1000;
            
            if (timer <= 31 && timer > 30 )
            {
                Debug.Log("Inside + " +  timer );
                TL1Lights[0].intensity = 1;
                flag1 = true;
                
            }
        }
        timer -= Time.deltaTime;
        if (timer <= 30 && timer > 20 && flag2 == false)
        {
            TL2Lights[0].intensity = 1000;
            //timer -= Time.deltaTime;
            if (timer <= 21 && timer > 20 )
            {
                TL2Lights[0].intensity = 1;
                flag2 = true;
            }
        }
        
        if (timer <= 20 && timer > 10 && flag3 == false)
        {
            TL3Lights[0].intensity = 1000;
            //timer -= Time.deltaTime;
            if (timer <= 11 && timer > 10 )
            {
                TL3Lights[0].intensity = 1;
                flag3 = true;
            }
        }
        
        if (timer <= 10 && flag4 == false)
        {
            TL4Lights[0].intensity = 1000;
            //timer -= Time.deltaTime;
            if (timer <= 1  )
            {
                Debug.Log("Inside");
                TL4Lights[0].intensity = 1;
                flag4 = true;
                timer = 39;
            }
        }

    }

    // IEnumerator increaseIntensity(Light [] TL1Lights)
    // {
    //     TL1Lights[0].intensity = 1000;
    //     yield return new WaitForSeconds(3);
    //     TL1Lights[0].intensity = 1;
    // }
}
