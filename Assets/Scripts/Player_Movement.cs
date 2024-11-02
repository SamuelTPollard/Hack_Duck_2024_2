using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float speed;
    Rigidbody rb;
    Transform camera;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        camera = transform.GetChild(0);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(camera.forward * speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
           rb.AddForce(-camera.forward * speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-camera.right * speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(camera.right * speed);
        }

    }
}
