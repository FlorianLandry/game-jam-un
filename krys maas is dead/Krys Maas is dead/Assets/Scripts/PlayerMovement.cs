using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody joueur;

    // Start is called before the first frame update
    void Start()
    {
        speed = 2000f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            joueur.AddForce(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            joueur.AddForce(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.Z))
        {
            joueur.AddForce(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            joueur.AddForce(0, 0, -speed * Time.deltaTime);
        }
    }
}
