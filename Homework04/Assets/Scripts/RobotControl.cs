using UnityEngine;

public class RobotControl : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 5f;
    public float rotationSpeed = 1f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }      
    void Update()
    {
        float sideForce = (Input.GetAxis("Horizontal") * rotationSpeed);
        float forwardForce = (Input.GetAxis("Vertical") * speed);
        rb.AddRelativeForce(forwardForce, 0f, 0f);
        rb.AddRelativeTorque(0f, sideForce, 0f);
    }    
}