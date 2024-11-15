using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itemunit : MonoBehaviour
{
    public int ItemHitCount = 0;
    public ScoreText scoreText; // ScoreTextへの参照を追加

    // Start is called before the first frame update
    void Start()
    {
        ItemHitCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Get");
        ItemHitCount++;
        Destroy(gameObject);

        // ゲットしたら ScoreText のカウントを増やす
        if (scoreText != null)
        {
            scoreText.IncrementScore(500); // 引数を渡す
        }
    }

}
