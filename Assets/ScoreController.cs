using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    public int score = 0;
    public int scoreChangeValue = 1;
    public TextMeshProUGUI scoreText;
    public int winningScore = 5;
    public TextMeshProUGUI winMessageText; // This is the variable declaration

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ScoreObject"))
        {
            // Add score when object collides with the collider
            score += scoreChangeValue;
            // Update the UI with the new score value
            scoreText.text = "Score: " + score.ToString();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("ScoreObject"))
        {
            // Subtract score when object exits the collider
            score -= scoreChangeValue;
            // Update the UI with the new score value
            scoreText.text = "Score: " + score.ToString();
        }
    }
    void UpdateScore()
    {
        scoreText.text = "Score: " + score.ToString();

        if (score >= winningScore)
        {
            winMessageText.gameObject.SetActive(true);
        }
    }
}

