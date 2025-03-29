using UnityEngine;
using UnityEngine.UI; // ใช้สำหรับแสดงคะแนนบน UI

public class BowlingScore : MonoBehaviour
{
    public Text scoreText;  // เชื่อมกับ UI Text
    private int score = 0;  // เก็บคะแนน

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
