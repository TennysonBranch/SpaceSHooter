using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    //made this array
    public GameObject[] hazards;
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;

    public Text winText;
    public Text ScoreText;
    public static int score;
    public Text restartText;
    public Text gameOverText;


    private bool gameOver;
    private bool restart;

    public AudioSource musicSource;
    public AudioClip musicClip;

    void Start()
    {
        gameOver = false;
        restart = false;
        restartText.text = "";
        gameOverText.text = "";
        winText.text = "";
        score = 0;
        UpdateScore();
        StartCoroutine (SpawnWaves());
        float getscrollspeed = BGScroller.scrollspeed;
        BGScroller.scrollspeed = -1;

    }


     void Update()
    {


        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    
        if (restart)
        {
            if(Input.GetKeyDown (KeyCode.T))
            {
                SceneManager.LoadScene("spaceshooter");
            }
        }
    }
    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                //added this
                GameObject hazard = hazards[Random.Range(0, hazards.Length)];
                Vector3 spawnPosition = new Vector3(Random.RandomRange(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait); 

            if (gameOver)
            {
                restartText.text = "Press 'T' for Restart";
                restart = true;
                break;
               
            }
        }
    }

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        ScoreText.text = "Points: " + score;
        if (score >= 100)
        {
            winText.text = "You win! Game Created by Tennyson Branch";
            gameOver = true;
            restart = true;
            float getscrollspeed = BGScroller.scrollspeed;
            BGScroller.scrollspeed = -10;
            // int getscore = GameController.score;
            // 
            //this needs work, play whenever score increases past 100
            //introduce an object that appears when score =100 that plays music
            musicSource.clip = musicClip;
            musicSource.Play();

        }
    }

    public void GameOver ()
    {
        gameOverText.text = "Game Over!";
        gameOver = true;

    }
}



