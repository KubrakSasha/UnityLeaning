using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] float mouseSensetivity = 450f;
    [SerializeField] Transform playerBody;
    [SerializeField] Light lighter;

    float xRotation = 0f;  
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }   

    void Update()
    {
        if (Input.GetKey(KeyCode.L)) 
        {
            lighter.enabled = lighter.enabled == false ? true : false;
        }

        float mouseX = Input.GetAxis("Mouse X") * mouseSensetivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensetivity * Time.deltaTime;
        playerBody.Rotate(Vector3.up * mouseX);

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -70f, 70f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        lighter.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

    }
}
