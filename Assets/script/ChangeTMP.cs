using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // TextMeshProの名前空間をインポート

public class ChangeTMP : MonoBehaviour
{

    public TextMeshProUGUI uiText;

    // Start is called before the first frame update
    void Start()
    {

        uiText.text = "Hello World";
    }

    // Update is called once per frame
    void Update()
    {

    }
}