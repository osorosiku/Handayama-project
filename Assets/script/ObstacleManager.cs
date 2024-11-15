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
        gameManager = obj.GetComponent<GameManager>();
        stageGrid = obj.GetComponent<GameManager>().stageGrid;
        // GenerateObstacle();


    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 300, 20), "Game Level: " + gameLevel);
    }
    void GenerateObstacle()
    {
        float pz = -47;
        for (int z = 0; z < 16; z++)
        {

            float px = -14;
            for (int x = 0; x < 6; x++)
            {
                Instantiate(obstacle, new Vector3(px, 1, pz), Quaternion.identity, parent);
                px += 5.5f;
            }
            pz += 6;

        }

    }
}