using UnityEngine;

public class BowlingPin : MonoBehaviour
{
    private bool hasScored = false;  // เช็คว่าพินนี้เคยนับคะแนนหรือยัง
    public float fallThreshold = 5f; // กำหนดมุมเอียงที่ถือว่าพินล้ม

    void Update()
    {
        if (!hasScored && Vector3.Dot(transform.up, Vector3.up) < Mathf.Cos(fallThreshold * Mathf.Deg2Rad))
        {
            hasScored = true;
            FindObjectOfType<BowlingScore>().AddScore(1); // เรียกไปเพิ่มคะแนนที่ BowlingScore
        }
    }
}
