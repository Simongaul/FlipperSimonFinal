using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TextMeshProUGUI scoreText;
    public int score;

    void Awake()
    {
        instance = this;
    }

    public void GainPoint(int points)
    {
        //score += points
        score = score + points;

        scoreText.text = "Score: " + score.ToString();

        //Debug.Log(score);
    }


}
