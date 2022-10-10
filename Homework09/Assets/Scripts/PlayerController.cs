using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 1f; 
    [SerializeField] float jumpForce = 5f;
    Animator animator;    
    Rigidbody2D rb;
    SpriteRenderer sr;
    bool grounded;
    
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }
        
    void Update()
    {        
        float movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3 (movement, 0, 0) * speed * Time.deltaTime;
        animator.SetBool("Running", movement != 0);
        sr.flipX = movement < 0 ? true : false;
        
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            Jump();
        }        
        animator.SetBool("Grounded", grounded);
        
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }        
    }
    void Jump() 
    {
        rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        animator.SetTrigger("Jump");
        grounded = false;
    }
    void Attack()
    {
        animator.SetTrigger("Attack");

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }        
    }    
}