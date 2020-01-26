using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stamina : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public Slider stamina;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            playerMovement.speed = 20f;
            stamina.value -= (Time.deltaTime / 4);
        }
        else
        {
            stamina.value += (Time.deltaTime / 10);
        }
    }
}
