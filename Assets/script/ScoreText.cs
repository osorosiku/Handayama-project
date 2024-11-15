using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    public TextMeshProUGUI uiText;
    public int score_num = 0; // スコア変数

    // 初期化
    void Start()
    {
    }

    // 更新
    void Update()
    {
        uiText.text = "Score:" + score_num; // スコアを表示
        score_num += 1;// 1ずつ加算
    }

    public void IncrementScore(int increment)
    {
        score_num += increment; // スコアを増やす
    }
}