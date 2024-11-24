using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class resultScore : MonoBehaviour
{
    public TextMeshProUGUI uiText; // スコア表示用のUI
    private int score_num = 0;     // スコア変数

    void Start()
    {
        // PlayerPrefsからスコアを取得
        score_num = PlayerPrefs.GetInt("Score", 0);

        // 取得したスコアをUIに反映
        if (uiText != null)
        {
            uiText.text = "Score: " + score_num.ToString();
        }
    }
}
