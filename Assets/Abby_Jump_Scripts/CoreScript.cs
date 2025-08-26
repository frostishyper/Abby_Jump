using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CoreScript : MonoBehaviour
{
    // GameObject Components & References
    public int PlayerScore;
    public Text ScoreText;
    public AudioSource CoreAudio;
    public AudioClip StartSound;
    public AudioClip Milestone;

    // Referencing A Canvas GameObject
    public GameObject GameOver_Screen;
    
    void Start()
    {
        CoreAudio.PlayOneShot(StartSound);
    }

    // Scoring Logic (Triggered By PillarGap.cs)
    public void AddScore(int ScoreToAdd)
    {
        PlayerScore += ScoreToAdd;
        ScoreText.text = PlayerScore.ToString();
        if (PlayerScore % 5 == 0)
        {
            CoreAudio.PlayOneShot(Milestone);
        }
    }
    
    // Retry Logic
    public void RetryGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    // Activate Gameover Overlay
    public void GameOver()
    {
        GameOver_Screen.SetActive(true);
    }
}
