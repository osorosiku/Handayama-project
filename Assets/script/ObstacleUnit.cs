using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleUnit : MonoBehaviour
{
    public int HitCount;
    // Start is called before the first frame update
    void Start()
    {
        HitCount = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //障害物にぶつかったときの処理はここに書く
            Debug.Log("Hit");
            HitCount++;
            Destroy(gameObject);
        }

    }
}
