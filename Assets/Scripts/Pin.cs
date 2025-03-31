using UnityEngine;

public class Pin : MonoBehaviour
{
    private bool hasFallen = false;
    private float fallThreshold = 5f; 

    void Update()
    {
        if (!hasFallen && Vector3.Angle(transform.up, Vector3.up) > fallThreshold)
        {
            hasFallen = true;
            BowlingGameManager.Instance.PinFell();
        }
    }
}
