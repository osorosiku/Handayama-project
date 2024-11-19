using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float forceAmount = 10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }




    void FixedUpdate()
    {

        float hori = Input.GetAxis("Horizontal");


        Vector3 movement = transform.forward + (transform.right * hori);


        rb.velocity = movement * forceAmount;
    }
}