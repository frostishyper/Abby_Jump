using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CoreScript : MonoBehaviour
{
    public int PlayerScore;
    public Text ScoreText;
    public GameObject GameOver_Screen;

    public void AddScore(int ScoreToAdd)
    {
        PlayerScore = PlayerScore + ScoreToAdd;
        ScoreText.text = PlayerScore.ToString();
    }

    public void RetryGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        GameOver_Screen.SetActive(true);
    }
}
