using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpingForce;
    private bool jumping = false;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        speed = 20f;
        jumpingForce = 400f;
        player = GameObject.Find("Joueur");
    }

    private void OnCollisionEnter(Collision collision)
    {
        jumping = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.position -= transform.right * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.Z))
        {
            transform.position += transform.forward * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * Time.deltaTime * speed;
        }
        if (Input.GetKeyDown(KeyCode.Space) && jumping == false)
        {
            player.GetComponent<Rigidbody>().AddForce(0, jumpingForce, 0);
            jumping = true;
        }

    }
}
