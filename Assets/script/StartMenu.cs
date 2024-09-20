using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void Onclick()
    {
        Debug.Log("Button Clicked");
        SceneManager.LoadScene("Main");

    }

    void Update()
    {

    }
}
