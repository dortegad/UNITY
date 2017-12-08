using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public GameObject signalType1;
    public GameObject signalType2;

    public Vector3 signalPosition;
    public Quaternion signalRotation;
    /*
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    */
    public float signalWait;
    public float startSignalWait;
    /*
    public float waveWait;

    public GUIText scoreText;
    public GUIText restartText;
    public GUIText gameOverText;
    private int score;

    private bool gameOver;
    private bool restart;
     */
    void Start()
    {
        //gameOver = false;
        //restart = false;
        //restartText.text = "";
        //gameOverText.text = "";
        //score = 0;
        //UpdateScore();
        StartCoroutine(SpawnWaves());
    }

    /*
    void Update()
    {
        if (restart)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("Main");
            }
        }
    }
     * */

    IEnumerator SpawnWaves()
    {
        //yield return new WaitForSeconds(startSignalWait);
        while (true)
        {
            //for (int i = 0; i < hazardCount; i++)
            //{
                //Vector3 signalPosition = new Vector3(spawnValues.x, spawnValues.y, spawnValues.z);
                //Quaternion spawnRotation = Quaternion.identity;
            if (Random.Range(-5, 5) > 0)
                signalPosition.x = -signalPosition.x;

            GameObject signal;
            if (Random.Range(-5, 5) > 0)
                signal = signalType1;
            else
                signal = signalType2;
            
            Instantiate(signal, signalPosition, signalRotation);


            yield return new WaitForSeconds(Random.Range(1, signalWait));
            //}
            //yield return new WaitForSeconds(waveWait);

            //if (gameOver)
            //{
            //    restartText.text = "Press 'R' for Restart";
            //    restart = true;
            //    break;
            //}
        }
    }

    /*
    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        gameOverText.text = "Game Over!";
        gameOver = true;
    }
     */
}
