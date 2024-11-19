using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class is_triger : MonoBehaviour
{
    public GameObject stage;
    public Transform stage_transform;

    private Vector3 nextstage_position;
    private GameManager gameManager;

    public int gameLevel = 0;

    // Start is called before the first frame update
    void Start()
    {
        nextstage_position = new Vector3(stage_transform.position.x, stage_transform.position.y, stage_transform.position.z + 100);
        GameObject obj = GameObject.Find("GameManager");
        gameManager = obj.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {


    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameLevel++;
            SpawnStage();
        }
    }

    void SpawnStage()
    {
        Instantiate(stage, nextstage_position, stage_transform.rotation);
        nextstage_position = new Vector3(stage_transform.position.x, stage_transform.position.y, stage_transform.position.z + 100);

    }
}

