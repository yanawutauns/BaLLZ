using UnityEngine;

public class BowlingShot : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float chargeSpeed = 10f;
    public float maxCharge = 100f;
    public float boostMultiplier = 2f;
    public float additionalBoost = 1.5f;

    public Rigidbody rb;
    private float chargePower = 0f;
    private bool hasShot = false;

    void Update()
    {
        if (!hasShot)
        {
            MoveLeftRight();
            ChargeAndShoot();
        }
    }

    void MoveLeftRight()
    {
        float moveInput = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * moveInput * moveSpeed * Time.deltaTime;
    }

    void ChargeAndShoot()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            chargePower += chargeSpeed * Time.deltaTime;
            chargePower = Mathf.Clamp(chargePower, 0, maxCharge);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            hasShot = true;
            Boost(chargePower);
            chargePower = 0;
        }
    }

    void Boost(float power)
    {
        float boostForce = power * boostMultiplier;

        if (chargePower == maxCharge)
        {
            boostForce *= additionalBoost;
        }

        rb.AddForce(Vector3.forward * boostForce, ForceMode.Impulse);
    }
}