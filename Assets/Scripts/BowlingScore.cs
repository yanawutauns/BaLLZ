using UnityEngine;
using UnityEngine.UI; // ������Ѻ�ʴ���ṹ�� UI

public class BowlingScore : MonoBehaviour
{
    public Text scoreText;  // ������Ѻ UI Text
    private int score = 0;  // �纤�ṹ

    public void AddScore(int points)
    {
        score += points;
        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }
}
