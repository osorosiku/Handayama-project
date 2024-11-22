using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itemunit : MonoBehaviour
{
    private ScoreText scoretext;
    private SE_Manager seManager; // SE_Managerクラスの参照

    // Start is called before the first frame update
    void Start()
    {
        scoretext = GameObject.Find("ScoreText ").GetComponent<ScoreText>();
        seManager = GameObject.FindObjectOfType<SE_Manager>(); // SE_Managerを取得
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
        if (seManager != null)
        {
            seManager.PlaySound3(); // サウンド3を鳴らす
        }
    }
}
