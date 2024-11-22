using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleUnit : MonoBehaviour
{
    private int HitCount = 0;
    private GameManager gameManager; // ゲームマネージャーへの参照
    private bool hasCollided = false;


    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && !hasCollided)
        {
            hasCollided = true;
            Destroy(gameObject);


            gameManager.IncrementHitCount();
        }
    }


    // GameManager との紐付け用メソッド

}
