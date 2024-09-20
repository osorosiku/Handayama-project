using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    ObstacleUnit obstacleUnit;
    GameObject obj;
    public int cnt;
    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.Find("testObj");
        obstacleUnit = obj.GetComponent<ObstacleUnit>();

    }

    // Update is called once per frame
    void Update()
    {
        cnt = obstacleUnit.HitCount;
        Debug.Log(cnt);
        if (cnt >= 1)
        {
            SceneManager.LoadScene("Result");
        }
    }
}
