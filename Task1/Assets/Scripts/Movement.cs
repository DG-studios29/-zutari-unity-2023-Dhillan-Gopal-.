using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Cubespeed = 5f;

    Rigidbody rb;
    Renderer rend;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        // Left Right Movement
        float x = Input.GetAxis("Horizontal");
        // Up Down Movement
        float y = Input.GetAxis("Vertical");

        
        if (x != 0 || y != 0)
        {
            Vector2 movement = new Vector2(x, y).normalized * Cubespeed;
            rb.velocity = movement;

            // colour change 
            if (x > 0)
            {
                GetComponent<Renderer>().material.color = Color.red;
            }
            else if (x < 0)
            {
                GetComponent<Renderer>().material.color = Color.blue;
            }
            else if (y > 0)
            {
                GetComponent<Renderer>().material.color = Color.green;
            }
            else if (y < 0)
            {
                GetComponent<Renderer>().material.color = Color.yellow;
            }
        }
        // When cube leaves camrea view
        Vector3 viewPos = Camera.main.WorldToViewportPoint(transform.position);

        if (viewPos.x < 0)
        {
            transform.position = Camera.main.ViewportToWorldPoint(new Vector3(1, viewPos.y, viewPos.z));
        }
        else if (viewPos.x > 1)
        {
            transform.position = Camera.main.ViewportToWorldPoint(new Vector3(0, viewPos.y, viewPos.z));
        }

        if (viewPos.y < 0)
        {
            transform.position = Camera.main.ViewportToWorldPoint(new Vector3(viewPos.x, 1, viewPos.z));
        }
        else if (viewPos.y > 1)
        {
            transform.position = Camera.main.ViewportToWorldPoint(new Vector3(viewPos.x, 0, viewPos.z));
        }
    }
}

