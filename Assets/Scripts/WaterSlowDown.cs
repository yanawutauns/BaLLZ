using UnityEngine;

public class WaterSlowDown : MonoBehaviour
{
    public float slowMultiplier = 0.5f; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball")) 
        {
            Rigidbody ballRb = other.GetComponent<Rigidbody>();
            if (ballRb != null)
            {
                ballRb.linearVelocity *= slowMultiplier; 
            }
        }
    }
}
