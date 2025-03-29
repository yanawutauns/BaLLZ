using UnityEngine;

public class BowlingPin : MonoBehaviour
{
    private bool hasScored = false;  // ����ҾԹ����¹Ѻ��ṹ�����ѧ
    public float fallThreshold = 5f; // ��˹�������§�������ҾԹ���

    void Update()
    {
        if (!hasScored && Vector3.Dot(transform.up, Vector3.up) < Mathf.Cos(fallThreshold * Mathf.Deg2Rad))
        {
            hasScored = true;
            FindObjectOfType<BowlingScore>().AddScore(1); // ���¡�������ṹ��� BowlingScore
        }
    }
}
