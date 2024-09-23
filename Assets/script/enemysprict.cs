using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class enemysprict : MonoBehaviour
{
    public float speed = 5f;  // 移動速度
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Rigidbodyを使って前方に力を加える
        rb.MovePosition(transform.position + transform.forward * speed * Time.fixedDeltaTime);
    }
}