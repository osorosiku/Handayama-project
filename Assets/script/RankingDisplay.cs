using UnityEngine;
using TMPro;

public class RankingDisplay : MonoBehaviour
{
    public Transform rankingParent; // ランキングを表示する親オブジェクト
    public GameObject rankingEntryPrefab; // ランキングのプレハブ（TextMeshProUGUI）

    private RankingManager rankingManager;

    void Start()
    {
        rankingManager = FindObjectOfType<RankingManager>();
        DisplayRanking();
    }

    void DisplayRanking()
    {
        foreach (Transform child in rankingParent)
        {
            Destroy(child.gameObject); // 古いランキングを削除
        }

        foreach (var entry in rankingManager.rankingList)
        {
            GameObject entryObj = Instantiate(rankingEntryPrefab, rankingParent);
            TextMeshProUGUI text = entryObj.GetComponent<TextMeshProUGUI>();
            text.text = $"{entry.playerName}: {entry.score}";
        }
    }
}

