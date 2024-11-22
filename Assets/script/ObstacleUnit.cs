using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleUnit : MonoBehaviour
{
    private int HitCount = 0;
    private GameManager gameManager; // ゲームマネージャーへの参照
    private bool hasCollided = false;
    private HP hp;


    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        hp = GameObject.Find("HP").GetComponent<HP>();

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
            hp.hpDown();
            Destroy(gameObject);


            gameManager.IncrementHitCount();
        }
    }




}
