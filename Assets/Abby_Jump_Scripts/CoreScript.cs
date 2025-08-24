using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoreScript : MonoBehaviour
{
    public int PlayerScore;
    public Text ScoreText;

    public void AddScore(int ScoreToAdd)
    {
        PlayerScore = PlayerScore + ScoreToAdd;
        ScoreText.text = PlayerScore.ToString();
    }
}
