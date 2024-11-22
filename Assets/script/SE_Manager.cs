using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE_Manager : MonoBehaviour
{
    public AudioClip sound1; // スコア条件達成時のサウンド
    public AudioClip sound2; // ヒット数増加時のサウンド
    public AudioClip sound3; // アイテム取得時のサウンド
    private AudioSource audioSource; // AudioSourceコンポーネント
    private int nextSoundScore = 2000; // 次に音を鳴らすスコアのしきい値

    public ScoreText scoreText; // ScoreTextスクリプトの参照

    void Start()
    {
        // AudioSourceコンポーネントを取得
        audioSource = GetComponent<AudioSource>();

        // ScoreTextスクリプトが指定されていない場合、自動で探す
        if (scoreText == null)
        {
            scoreText = FindObjectOfType<ScoreText>();
        }
    }

    void Update()
    {
        // スコアがしきい値に達した場合
        if (scoreText != null && scoreText.score_num >= nextSoundScore)
        {
            audioSource.PlayOneShot(sound1); // サウンド1を再生
            nextSoundScore += 5000; // 次のしきい値を更新
        }
    }

    // ヒット数増加時にサウンド2を鳴らす
    public void PlaySound2()
    {
        if (sound2 != null)
        {
            audioSource.PlayOneShot(sound2); // サウンド2を再生
        }
    }

    // アイテムを取得したときにサウンド3を鳴らす
    public void PlaySound3()
    {
        if (sound3 != null)
        {
            audioSource.PlayOneShot(sound3); // サウンド3を再生
        }
    }
}






