using UnityEngine;
using TMPro; 

public class BowlingGameManager : MonoBehaviour
{
    public static BowlingGameManager Instance;
    private int score = 0;
    public TMP_Text scoreText; 

    void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    void Start()
    {
        UpdateScoreUI();
    }

    public void PinFell()
    {
        score += 1;
        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }
}
