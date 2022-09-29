using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller2 : MonoBehaviour
{
    [SerializeField] float movementSpeed = 2.0f;
    [SerializeField] float sprintSpeed = 5.0f;
    [SerializeField] float rotationSpeed = 0.2f;
    [SerializeField] float animationSpeed = 0.2f;
    float jumpSpeed = 7.0f;

    CharacterController controllerr;
    Animator animator;
    Camera characterCamera;
    float rotationAngle = 0.0f;
    float targetAnimationSpeed = 0.0f;

    bool isSprint = false;
    float speedY = 0.0f;
    float gravity = -9.81f;
    bool isJumping = false;
    bool isRun = false;
    bool isDead = false;
    //bool isAttacking= false;
    bool isSpawn;
    float vertical;
    float horizontal;

    public CharacterController Controllerr { get { return controllerr = controllerr ?? GetComponent<CharacterController>(); } }
    public Animator Animator { get { return animator = animator ?? GetComponent<Animator>(); } }
    public Camera CharacterCamera { get { return characterCamera = characterCamera ?? FindObjectOfType<Camera>(); } }


    private void Start()
    {        
        Animator.SetTrigger("Spawn");
    }
    void Update()
    {        
        if (!isDead && !isSpawn)
        {            
            vertical = Input.GetAxis("Vertical");
            horizontal = Input.GetAxis("Horizontal");
        }
        
        //Jumping
        if (Input.GetButtonDown("Jump") && !isJumping && !isDead && !isSpawn)
        {
            isJumping = true;
            Animator.SetTrigger("Jump");
            speedY += jumpSpeed;            
        }
        if (!Controllerr.isGrounded)
        {
            speedY += gravity * Time.deltaTime;            
        }
        else if (speedY < 0.0f)
        {
            speedY = 0.0f;            
        }
        Animator.SetFloat("SpeedY", speedY / jumpSpeed);
        if (isJumping && speedY < 0.0f)
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, Vector3.down, out hit, 1f, LayerMask.GetMask("Default")))
            {
                isJumping = false;
                Animator.SetTrigger("Land");                
            }
        }

        //Moving
        isSprint = Input.GetKey(KeyCode.LeftShift);
        Vector3 movement = new Vector3(horizontal, 0.0f, vertical);
        Vector3 rotatedMovement = Quaternion.Euler(0.0f, CharacterCamera.transform.rotation.eulerAngles.y, 0.0f) * movement.normalized;
        Vector3 verticalMovement = Vector3.up * speedY;
        float currentSpeed = isSprint ? sprintSpeed : movementSpeed;
        Controllerr.Move((verticalMovement + rotatedMovement * currentSpeed) * Time.deltaTime);
        if (rotatedMovement.sqrMagnitude > 0f)
        {
            rotationAngle = Mathf.Atan2(rotatedMovement.x, rotatedMovement.z) * Mathf.Rad2Deg;
            targetAnimationSpeed = isSprint ? 1.0f : 0.5f;
        }
        else
        {
            targetAnimationSpeed = 0.0f;
        }
        Animator.SetFloat("Speed", Mathf.Lerp(Animator.GetFloat("Speed"), targetAnimationSpeed, animationSpeed));
        Quaternion currentRotation = Controllerr.transform.rotation;
        Quaternion targetRotation = Quaternion.Euler(0.0f, rotationAngle, 0.0f);
        Controllerr.transform.rotation = Quaternion.Lerp(currentRotation, targetRotation, rotationSpeed);

        //Death
        if (Input.GetKeyDown(KeyCode.C))
        {
            Animator.SetTrigger("Death");
            isDead = true;
        }

        //Attack
        if (Input.GetMouseButtonDown(0))
        {
            //isAttacking = true;
            Animator.SetTrigger("Attacking");
            Animator.SetInteger("Attack", Random.Range(0, 4));            
        }
    }    
    void StartSpawn() 
    {
        isSpawn = true;
    }
    void EndSpawn()
    {
        isSpawn = false;
    }
}