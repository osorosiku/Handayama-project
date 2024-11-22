using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itemunit : MonoBehaviour
{
    private ScoreText scoretext;



    // Start is called before the first frame update
    void Start()
    {

        scoretext = GameObject.Find("ScoreText ").GetComponent<ScoreText>();


    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Get");
        Destroy(gameObject);
        scoretext.IncrementScore(500);

    }

}
