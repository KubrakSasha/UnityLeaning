using UnityEngine;

public class RobotControl : MonoBehaviour
{
    Rigidbody rigidbody;
    public float speed = 5f;
    public float rotationSpeed = 1f;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }      
    void Update()
    {
        float sideForce = (Input.GetAxis("Horizontal") * rotationSpeed);
        float forwardForce = (Input.GetAxis("Vertical") * speed);
        rigidbody.AddRelativeForce(forwardForce, 0f, 0f);
        rigidbody.AddRelativeTorque(0f, sideForce, 0f);
    }    
}