using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;

    // Start is called before the first frame update
    void Awake()
    {
        gameManager = this;
        //if (gameManager == null)
        {
            //DontDestroyOnLoad(gameObject);
            //gameManager = this;
        }

        //else if (gameManager != this) 
        {
            //Destroy(gameObject);
        }
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

    public void Quitgame() 
    {
        Application.Quit();
    }
}
