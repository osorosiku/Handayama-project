using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int totalHitCount = 0; // 全体のヒット数を管理する変数
    private ObstacleUnit[] obstacleUnits; // 障害物ユニットの配列

    // Start is called before the first frame update
    void Start()
    {
        // シーン内のすべての ObstacleUnit コンポーネントを取得
        obstacleUnits = FindObjectsOfType<ObstacleUnit>();

        // 各 ObstacleUnit に GameManager を通知するためのメソッドを設定
        foreach (var unit in obstacleUnits)
        {
            unit.SetGameManager(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Total Hit Count: " + totalHitCount);
        if (totalHitCount >= 3) // ヒット数の条件を満たしたらシーンを変更
        {
            SceneManager.LoadScene("Result");
        }
    }

    // ヒットカウントを増やすメソッドを作成
    public void IncrementHitCount()
    {
        totalHitCount++;
    }
}
