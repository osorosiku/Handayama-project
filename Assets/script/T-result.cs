
using UnityEngine;
using UnityEngine.SceneManagement; // シーンの管理に必要

public class SceneChangeOnKey : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // 'T'キーが押された場合
        if (Input.GetKeyDown(KeyCode.T))
        {
            
            // Resultシーンに切り替え
            SceneManager.LoadScene("Result");
        }
    }
}
