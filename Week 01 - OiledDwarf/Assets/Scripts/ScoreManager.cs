using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public static int Score { get; private set; }

    public Text scoreText;

    void Awake()
    {
        instance = this;
        Score = 0;
    }

    public void IncreaseScore(int amount)
    {
        Score += amount;
        UpdateText();
    }

    public void DecreaseScore(int amount)
    {
        Score -= amount;
        UpdateText();
    }

    private void UpdateText()
    {
        scoreText.text = "" + Score;
    }
}
