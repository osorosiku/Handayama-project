using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;  // 追加しましょう

public class ScoreManager : MonoBehaviour
{

  public GameObject score_object = null;
  public int score_num = 0;

  public TextMeshProUGUI uiText;
  void Start()
  {
  }

  // 更新
  void Update()
  {
    uiText.text = "Score:" + score_num;

    score_num += 1;
  }
}