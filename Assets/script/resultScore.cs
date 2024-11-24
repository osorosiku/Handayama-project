using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class resultScore : MonoBehaviour
{
    public TextMeshProUGUI uiText; // スコア表示用のUI
    private int score_num = 0;     // スコア変数
    private int gamecount = 0;

    void Start()
    {
        // PlayerPrefsからスコアを取得
        score_num = PlayerPrefs.GetInt("Score", 0);
        gamecount = PlayerPrefs.GetInt("MainScenePlayCount", 0);


        uiText.text = "Score: " + score_num.ToString() + "\nGameCount " + gamecount.ToString();

    }
}
