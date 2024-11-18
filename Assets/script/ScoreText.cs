using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    public static ScoreText Instance; // インスタンスへのアクセス
    public int score_num = 0; // スコア

    public TextMeshProUGUI uiText; // スコアを表示するUI

    private float timer = 0f; // タイマー用変数
    public float scoreInterval = 1f; // スコアを加算する間隔（秒）
    public int scoreIncrement = 10; // 加算するスコアの値

    // シングルトンの設定
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this; // 初めてのインスタンスがあればそれを設定
            DontDestroyOnLoad(gameObject); // シーン遷移しても破棄されないようにする
        }
        else
        {
            Destroy(gameObject); // 他のインスタンスがあればこれを破棄
        }
    }

    void Start()
    {
        // スコア表示の初期化
        UpdateScoreText();

        // 1秒ごとにスコアを加算する
        InvokeRepeating("IncrementScoreOverTime", scoreInterval, scoreInterval);
    }

    void Update()
    {
        // スコアをUIに反映する
        UpdateScoreText();
    }

    // スコアを加算
    public void IncrementScore(int increment)
    {
        score_num += increment;
        UpdateScoreText();
    }

    // スコアのUI表示を更新
    private void UpdateScoreText()
    {
        if (uiText != null)
        {
            uiText.text = "Score: " + score_num;
        }
    }

    // 1秒ごとにスコアを加算
    private void IncrementScoreOverTime()
    {
        score_num += scoreIncrement;
        UpdateScoreText();
    }

    // スコアを保存
    public void SaveScore()
    {
        PlayerPrefs.SetInt("PlayerScore", score_num);
        PlayerPrefs.Save();
    }

    // スコアを読み込む
    public void LoadScore()
    {
        score_num = PlayerPrefs.GetInt("PlayerScore", 0);
        UpdateScoreText();
    }
}








    
