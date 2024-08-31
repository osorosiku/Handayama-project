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
        float vert = Input.GetAxis("Vertical");   // W, Sキーの入力を取得

        // 入力に基づいて移動ベクトルを計算
        Vector3 movement = (transform.right * hori) + (transform.forward * vert);

        // Rigidbodyの速度を設定
        rb.velocity = movement * forceAmount;
    }
}
//gitbranch-test