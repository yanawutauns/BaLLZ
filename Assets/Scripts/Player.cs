using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 5.0f;
    public float rollSpeed = 1.0f; 

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 moveDirection = Vector3.zero;
        Vector3 rollAxis = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            moveDirection = Vector3.forward;
            rollAxis = Vector3.right;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            moveDirection = Vector3.back;
            rollAxis = Vector3.left;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            moveDirection = Vector3.left;
            rollAxis = Vector3.forward;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            moveDirection = Vector3.right;
            rollAxis = Vector3.back;
        }

        if (moveDirection != Vector3.zero)
        {
            rb.AddForce(moveDirection * movementSpeed, ForceMode.Acceleration);
            rb.AddTorque(rollAxis * rollSpeed, ForceMode.VelocityChange);
        }
    }
}
