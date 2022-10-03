using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController characterController;
    [SerializeField] float speed = 12f;
    [SerializeField] Transform targetUp;
    [SerializeField] Transform targetDown;    
    float gravity = -9.81f;
    Vector3 velocity;

    public CharacterController CharacterController { get { return characterController = characterController ?? GetComponent<CharacterController>(); } }
       
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");        
        Vector3 move = transform.right * x + transform.forward * z;
        velocity.y += gravity;
        CharacterController.Move(move * speed * Time.deltaTime + velocity * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {   if (other.CompareTag("Up"))
        {
            transform.position = targetUp.position;
        }
        else if (other.CompareTag("Down"))
        {
            transform.position = targetDown.position;
        }
    }
}