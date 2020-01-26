using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightController : MonoBehaviour
{
    public GameObject targetLight;
    public Material[] skies;
    public float dayTimer;
    public bool isCycle;
    public float daySpeed = 0.5f;
    public float dayTimerInit;

    void Start()
    {
        dayTimer = targetLight.GetComponent<Light>().intensity;
        dayTimerInit = dayTimer;
    }
    
    void Update()
    {
        if((targetLight.GetComponent<Light>().intensity = dayTimer -= Time.deltaTime * daySpeed) < 0)
        {
            targetLight.GetComponent<Light>().intensity = 1;
            dayTimer = dayTimerInit;
        }
        
        
        changeCycle();
    }

    void changeCycle()
    {
        if(dayTimer >= 0.75f)
        {
            Camera.main.GetComponent<Skybox>().material = skies[0];
        } else if (dayTimer >= 0.5f)
        {
            Camera.main.GetComponent<Skybox>().material = skies[1];
        } else if(dayTimer >= 0.25f)
        {
            Camera.main.GetComponent<Skybox>().material = skies[2];
        } else if (dayTimer >= 0.0f)
        {
            Camera.main.GetComponent<Skybox>().material = skies[3];
        }
    }
}
