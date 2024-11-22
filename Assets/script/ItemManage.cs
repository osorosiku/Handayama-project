using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManage : MonoBehaviour
{
    GameManager gameManager;
    int[,,] stageGrid;
    public GameObject item;
    GameObject game;
    private Transform parent;
    // Start is called before the first frame update
    void Start()
    {
        game = GameObject.Find("GameManager");
        gameManager = game.GetComponent<GameManager>();
        stageGrid = gameManager.stageGrid;
        parent = this.transform;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void GenerateItem(int gl)
    {


        if (gl == 0)
        {
            return;
        }
        float baseZ = -47 + (100 * (gl)); // ゲームレベルに応じたZ座標の調整
        float baseX = -14;
        float y = 0.29f;
        for (int z = 0; z < 16; z++)
        {
            float px = baseX;
            for (int x = 0; x < 6; x++)
            {
                // アイテムがある場所でアイテムを生成
                if (stageGrid[x, z, gl] == 1)
                {

                    Instantiate(item, new Vector3(px, y, (baseZ + (z * 6))), Quaternion.identity, parent);
                }
                px += 5.5f;// 次のX座標に移動
            }
        }
    }
}
