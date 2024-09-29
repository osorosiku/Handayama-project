using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleUnit : MonoBehaviour
{
    public int HitCount = 0; // 個別のヒット数（未使用）
    private GameManager gameManager; // ゲームマネージャーへの参照

    // Start is called before the first frame update
    void Start()
    {
        HitCount = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit");
        HitCount++;
        Destroy(gameObject);

        // ヒットしたら GameManager のカウントを増やす
        if (gameManager != null)
        {
            gameManager.IncrementHitCount();
        }
    }

    // GameManager との紐付け用メソッド
    public void SetGameManager(GameManager manager)
    {
        gameManager = manager;
    }
}
