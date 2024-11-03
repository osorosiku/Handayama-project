using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{

    public Transform triger;
    private Vector3 obstacle_position;
    public GameObject obstacle;
    private Transform parent;

    // Start is called before the first frame update
    void Start()
    {
        parent = this.transform;
        obstacle_position = new Vector3(0, 0, triger.position.z);
        Instantiate(obstacle, new Vector3(-1, 1, -8), Quaternion.identity, parent);
    }

    // Update is called once per frame
    void Update()
    {

    }



}
