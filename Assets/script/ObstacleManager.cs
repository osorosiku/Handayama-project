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
        gameLevel = obj2.GetComponent<is_triger>().gameLevel;
        gameLevel = 5;
        stageGrid = gameManager.stageGrid;
        //GenerateObstacle(gameLevel);
    }

    // Update is called once per frame
    void Update()
    {



    }






    public void GenerateObstacle(int gl)
    {
        Debug.Log("GenerateObstacle");
        float pz = -47;
        for (int z = 0; z < 16; z++)
        {
            float px = -14;
            for (int x = 0; x < 6; x++)
            {
                if (stageGrid[x, z, gl] == 2)



                {
                    Instantiate(obstacle, new Vector3(px, -1, pz), Quaternion.identity, parent);
                }
                px += 5.5f;
            }
            pz += 6;
        }
    }
}



