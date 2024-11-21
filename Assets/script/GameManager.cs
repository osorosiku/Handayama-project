using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int totalHitCount = 0; // 全体のヒット数を管理する変数
    private ObstacleUnit[] obstacleUnits; // 障害物ユニットの配列
    public int[,,] stageGrid = new int[6, 40, 100];







    void Start()
    {
        // シーン内のすべての ObstacleUnit コンポーネントを取得
        obstacleUnits = FindObjectsOfType<ObstacleUnit>();

        // 各 ObstacleUnit に GameManager を通知するためのメソッドを設定
        foreach (var unit in obstacleUnits)
        {
            unit.SetGameManager(this);
        }
        initGrid();




    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Total Hit Count: " + totalHitCount);
        if (totalHitCount >= 3) // ヒット数の条件を満たしたらシーンを変更
        {
            SceneManager.LoadScene("Result");
        }
    }

    // ヒットカウントを増やすメソッドを作成
    public void IncrementHitCount()
    {
        totalHitCount++;
        Debug.Log("Total Hit Count: " + totalHitCount);
    }

    void initGrid()
    {
        System.Random random = new System.Random();

        for (int level = 1; level <= 100; level++)
        {
            float obstacleRate = Mathf.Clamp(0.1f + (level - 1) * 0.02f, 0.1f, 0.5f); // 障害物の割合（最大50%）
            float itemRate = Mathf.Clamp(0.2f - (level - 1) * 0.01f, 0.05f, 0.2f);     // アイテムの割合（最小5%）

            for (int z = 0; z < 40; z++)
            {
                for (int x = 0; x < 6; x++)
                {
                    float rand = (float)random.NextDouble();

                    if (rand < obstacleRate)
                    {
                        stageGrid[x, z, level - 1] = 2; // 障害物
                    }
                    else if (rand < obstacleRate + itemRate)
                    {
                        stageGrid[x, z, level - 1] = 1; // アイテム
                    }
                    else
                    {
                        stageGrid[x, z, level - 1] = 0; // 何もなし
                    }
                }
            }
        }

    }
}
