using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerScore
{
    public string playerName; // プレイヤー名
    public int score; // スコア

    public PlayerScore(string name, int score)
    {
        this.playerName = name;
        this.score = score;
    }
}

public class RankingManager : MonoBehaviour
{
    private const int MaxRankingEntries = 10; // ランキングに表示する最大エントリー数
    private const string RankingKey = "RankingData"; // PlayerPrefsのキー

    public List<PlayerScore> rankingList = new List<PlayerScore>();

    void Start()
    {
        LoadRanking();
    }

    // スコアをランキングに追加
    public void AddScore(string playerName, int score)
    {
        rankingList.Add(new PlayerScore(playerName, score));
        SortAndTrimRanking();
        SaveRanking();
    }

    // ランキングをソートして上位を保持
    private void SortAndTrimRanking()
    {
        rankingList.Sort((a, b) => b.score.CompareTo(a.score)); // スコア降順にソート
        if (rankingList.Count > MaxRankingEntries)
        {
            rankingList.RemoveRange(MaxRankingEntries, rankingList.Count - MaxRankingEntries);
        }
    }

    // ランキングを保存
    private void SaveRanking()
    {
        string json = JsonUtility.ToJson(new SerializableRanking(rankingList));
        PlayerPrefs.SetString(RankingKey, json);
        PlayerPrefs.Save();
    }

    // ランキングを読み込む
    private void LoadRanking()
    {
        string json = PlayerPrefs.GetString(RankingKey, "{}");
        SerializableRanking data = JsonUtility.FromJson<SerializableRanking>(json);
        rankingList = data?.scores ?? new List<PlayerScore>();
    }

    // ランキングデータを管理する内部クラス
    [System.Serializable]
    private class SerializableRanking
    {
        public List<PlayerScore> scores;

        public SerializableRanking(List<PlayerScore> scores)
        {
            this.scores = scores;
        }
    }
}

