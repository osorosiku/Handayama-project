using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int totalHitCount = 0;
    private ObstacleUnit[] obstacleUnits;
    public int[,,] stageGrid = new int[10, 40, 100];

    public static int gameLevel = 0;

    private SE_Manager seManager; // SE_Managerの参照

    void Start()
    {
        initGrid();

        // SE_Managerコンポーネントを取得
        seManager = FindObjectOfType<SE_Manager>(); // シーン内のSE_Managerを探す
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Total Hit Count: " + totalHitCount);
        if (totalHitCount >= 3) // ヒット数の条件を満たしたらシーンを変更
        {
            SceneManager.LoadScene("Result");

        }
        EndGame();
    }

    // ヒットカウントを増やすメソッドを作成
    public void IncrementHitCount()
    {
        totalHitCount++;
        Debug.Log("Total Hit Count: " + totalHitCount);
        Debug.Log("Total Hit Count: " + totalHitCount + " (called at " + Time.time + ")");

        // ヒット数が増えるたびにサウンド2を再生
        if (seManager != null)
        {
            seManager.PlaySound2(); // Sound2を鳴らすメソッド
        }
    }

    void initGrid()
    {
        System.Random random = new System.Random();

        for (int level = 1; level <= 100; level++)
        {
            float obstacleRate = Mathf.Clamp(0.2f + (level - 1) * 0.02f, 0.1f, 0.6f);
            float itemRate = Mathf.Clamp(0.02f - (level - 1) * 0.01f, 0.05f, 0.2f);

            for (int z = 0; z < 40; z++)
            {
                for (int x = 0; x < 10; x++)
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

    void PrintStageGrid()
    {
        for (int level = 0; level < 100; level++) // 各レベルごとに出力
        {
            Debug.Log($"==== Level {level} ====");
            for (int z = 0; z < 40; z++)
            {
                string row = "";
                for (int x = 0; x < 6; x++)
                {
                    row += stageGrid[x, z, level] + " ";
                }
                Debug.Log(row.Trim()); // 各行を出力
            }
        }
    }
    private void EndGame()
    {
        //Escが押された時
        if (Input.GetKey(KeyCode.Escape))
        {

#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;//ゲームプレイ終了
#else
            Application.Quit();//ゲームプレイ終了
#endif
        }

    }
}

