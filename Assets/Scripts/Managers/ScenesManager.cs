using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeLevel()
    {
        SceneManager.LoadScene("MainGame");

    }

    public void MenuScene()
    {
        SceneManager.LoadScene("Menu Scene");
    }

    public void LoseScreen()
    {
        SceneManager.LoadScene("LoseScreen");
    }

    public void EndScreen()
    {
        SceneManager.LoadScene("End Screen 1");
    }

    public void Quitgame()
    {
        Application.Quit();
    }
}
