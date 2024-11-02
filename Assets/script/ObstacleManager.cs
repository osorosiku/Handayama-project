using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{

    public Transform triger;
    private Vector3 obstacle_position;
    public GameObject obstacle;

    // Start is called before the first frame update
    void Start()
    {

        obstacle_position = new Vector3(0, 0, triger.position.z);
        Instantiate(obstacle, new Vector3(9, 11, 1), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }



}
