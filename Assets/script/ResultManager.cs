using UnityEngine;
using TMPro;

public class ResultManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    void Start()
    {
        // ScoreTextのインスタンスからスコアを取得
        scoreText.text = "Score: " + ScoreText.Instance.score_num;
    }
}


