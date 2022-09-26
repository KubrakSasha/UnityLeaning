using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    
    //public float mouseSensetivity = 100f;        
    CharacterController controller;
    [SerializeField] GameObject xCameraRotation;
    [SerializeField] Joystick moveJoystick;
    [SerializeField] Joystick cameraJoystick;    
    [SerializeField] float speed = 12.0f;
    [SerializeField] float jumpHeight = 3f;
    float gravity = -9.81f;

    float groundDistance = 0.4f;
    public Transform groundCheck;   
    public LayerMask groundMask;
    bool isGrounded;

    Vector3 velocity;
    float xRotation = 0f;    
    float vertical;
    float horizontal;
    float mouseX;
    float mouseY;
    public CharacterController Controller 
    { get { return controller = controller ?? GetComponent<CharacterController>(); } }
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;        
        if (!Application.isMobilePlatform) 
        {
            moveJoystick.gameObject.SetActive(false);
            cameraJoystick.gameObject.SetActive(false);
        }
    }
    void Update()
    {        
        if (Application.isMobilePlatform)
        {
            vertical = moveJoystick.Vertical;
            horizontal = moveJoystick.Horizontal;
            mouseX = cameraJoystick.Horizontal;
            mouseY = cameraJoystick.Vertical;
            Debug.Log("mobile");
        }
        else 
        {
            vertical = Input.GetAxis("Vertical");
            horizontal = Input.GetAxis("Horizontal");
            mouseX = Input.GetAxis("Mouse X");
            mouseY = Input.GetAxis("Mouse Y");
            Debug.Log("pc");
        }

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }       
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -70f, 70f);        
        Vector3 movement = new Vector3(horizontal * speed, gravity, vertical * speed);
        Controller.Move(transform.TransformDirection(movement) * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
        }
        velocity.y += gravity * Time.deltaTime;

        Controller.Move(velocity * Time.deltaTime);
        Controller.transform.Rotate(Vector3.up, mouseX);        
        xCameraRotation.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);        
    }    
}