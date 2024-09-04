using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
        // 入力値を取得
        float hori = Input.GetAxis("Horizontal"); // A, Dキーの入力を取得

        // 常に前に進むベクトルを追加
        Vector3 movement = transform.forward + (transform.right * hori);

        // Rigidbodyの速度を設定
        rb.velocity = movement * forceAmount;
    }
}