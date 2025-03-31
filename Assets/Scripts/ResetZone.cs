using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball")) // ตรวจสอบว่าเป็นลูกโบลิ่ง
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // รีโหลดซีน
        }
    }
}
