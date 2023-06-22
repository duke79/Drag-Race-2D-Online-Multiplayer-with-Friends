using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;

    private void Start()
    {
        scoreText.text = "Score: 0";
    }

    public void UpdateScore(int value)
    {
        score += value;
        scoreText.text = "Score: " + score.ToString();
    }
}
