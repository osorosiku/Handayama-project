using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public Transform triger;
    private Vector3 obstacle_position;
    public GameObject obstacle;
    private Transform parent;

    public int gameLevel = 0;

    int[,,] stageGrid;

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        parent = this.transform;
        obstacle_position = new Vector3(0, 0, triger.position.z);
        GameObject obj = GameObject.Find("GameManager");
        GameObject obj2 = GameObject.Find("Triger");
        gameManager = obj.GetComponent<GameManager>();
        stageGrid = obj.GetComponent<GameManager>().stageGrid;
        gameLevel = obj2.GetComponent<is_triger>().gameLevel;
        gameLevel = 1;
        initGrid();
        GenerateObstacle(gameLevel);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject obj2 = GameObject.Find("Triger");
        gameLevel = obj2.GetComponent<is_triger>().gameLevel;

        Debug.Log(gameLevel);
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
                for (int x = 0; x < 8; x++)
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
        Debug.Log($"Level:");
        string levelData = "";
        for (int z = 0; z < 40; z++)
        {
            string row = "";
            for (int x = 0; x < 6; x++)
            {
                row += stageGrid[x, z, 1] + " ";
            }
            levelData += row + "\n"; // 行ごとに改行を追加
        }
        Debug.Log(levelData);
    }


    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 300, 20), "Game Level: " + gameLevel);
    }

    void GenerateObstacle(int gl)
    {
        float pz = -47;
        for (int z = 0; z < 16; z++)
        {
            float px = -14;
            for (int x = 0; x < 8; x++)
            {
                if (stageGrid[x, z, gl] == 2)
                {
                    Instantiate(obstacle, new Vector3(px, -1, pz), Quaternion.identity, parent);
                    px += 5.5f;
                }
            }
            pz += 6;
        }
    }

}



