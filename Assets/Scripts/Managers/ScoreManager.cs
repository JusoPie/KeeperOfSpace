using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;

    public GameObject spawner;
    public GameObject spawner1;
    public GameObject spawner2;
    public GameObject spawner3;
    public GameObject tankSpawner;
    public GameObject tankSpawner1;
    public GameObject tankSpawner2;
    public GameObject waspSpawner;

    int score = 0;
    int highScore = 0;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        scoreText.text ="Score: " + score.ToString();
        highScoreText.text = "High Score: " + highScore.ToString();
    }

    

    public void AddScore(int addedscore) 
    {
        score += addedscore;
        scoreText.text = "Score: " + score.ToString();
        if (score >= 10 && score<15)
        {
            spawner.SetActive(false);
            spawner1.SetActive(false);
            spawner2.SetActive(false);
            spawner3.SetActive(false);
            tankSpawner.SetActive(true);

        }

        if (score >= 15)
        {
            spawner.SetActive(true);
            spawner.GetComponent<KamikazeSpawner>().respawn();
            spawner1.SetActive(true);
            spawner1.GetComponent<KamikazeSpawner>().respawn();
            spawner2.SetActive(true);
            spawner2.GetComponent<KamikazeSpawner>().respawn();
            spawner3.SetActive(true);
            spawner3.GetComponent<KamikazeSpawner>().respawn();
            tankSpawner.SetActive(true);
        }

        if (score >= 40 && score < 52)
        {
            spawner.SetActive(false);
            spawner1.SetActive(false);
            spawner2.SetActive(false);
            spawner3.SetActive(false);
            tankSpawner.SetActive(false);
            tankSpawner.GetComponent<TankSpawner>().spawn();
            tankSpawner1.SetActive(true);
            tankSpawner2.SetActive(true);

        }

        if (score >= 52)
        {
            spawner.SetActive(true);
            spawner.GetComponent<KamikazeSpawner>().respawn();
            spawner1.SetActive(true);
            spawner1.GetComponent<KamikazeSpawner>().respawn();
            spawner2.SetActive(true);
            spawner2.GetComponent<KamikazeSpawner>().respawn();
            spawner3.SetActive(true);
            spawner3.GetComponent<KamikazeSpawner>().respawn();
            tankSpawner.SetActive(true);
            tankSpawner.GetComponent<TankSpawner>().respawn();
            tankSpawner1.SetActive(false);
            tankSpawner1.GetComponent<TankSpawner>().spawn();
            tankSpawner2.SetActive(false);
            tankSpawner2.GetComponent<TankSpawner>().spawn();
        }

        if (score >= 80 && score < 90)
        {
            spawner.SetActive(false);
            spawner.GetComponent<KamikazeSpawner>().spawn();
            spawner1.SetActive(false);
            spawner1.GetComponent<KamikazeSpawner>().spawn();
            spawner2.SetActive(false);
            spawner2.GetComponent<KamikazeSpawner>().spawn();
            spawner3.SetActive(false);
            spawner3.GetComponent<KamikazeSpawner>().spawn();
            tankSpawner.SetActive(false);
            tankSpawner.GetComponent<TankSpawner>().spawn(); 
            waspSpawner.SetActive(true);
        }
    }
}
