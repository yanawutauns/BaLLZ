using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball")) // ��Ǩ�ͺ������١����
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // ����Ŵ�չ
        }
    }
}
