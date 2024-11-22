using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public Transform triger;
    private Vector3 obstacle_position;
    public GameObject obstacle;
    private Transform parent;

    private int[,,] stageGrid;



    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        parent = this.transform;
        obstacle_position = new Vector3(0, 0, triger.position.z);
        GameObject obj = GameObject.Find("GameManager");
        GameObject obj2 = GameObject.Find("Triger");
        gameManager = obj.GetComponent<GameManager>();
        stageGrid = gameManager.stageGrid;
    }

    // Update is called once per frame
    void Update()
    {



    }






    public void GenerateObstacle(int gl)
    {
        Debug.Log("GenerateObstacle");


        float baseZ = -47 + (100 * (gl + 1)); // ゲームレベルに応じたZ座標の調整
        float baseX = -15;

        for (int z = 0; z < 16; z++)
        {
            float px = baseX;
            for (int x = 0; x < 10; x++)
            {
                // 障害物がある場所で障害物を生成
                if (stageGrid[x, z, gl] == 2)
                {
                    Instantiate(obstacle, new Vector3(px, -1, (baseZ + (z * 6))), Quaternion.identity, parent);

                }

                px += 3.01f;// 次のX座標に移動
            }
        }
    }
}




