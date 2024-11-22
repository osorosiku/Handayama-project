using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HP : MonoBehaviour
{
    int hp = 3;
    // Start is called before the first frame update
    public TextMeshProUGUI uiText;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        uiText.text = "HP:" + hp;
    }
    public void hpDown()
    {
        hp--;
    }
}
