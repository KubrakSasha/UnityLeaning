using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    float moveHorizontal, moveVertical;
    PlayerAnimation playerAnimation;
    [SerializeField] float moveSpeed = 1.0f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        playerAnimation = GetComponentInChildren<PlayerAnimation>();
    }
    private void FixedUpdate()
    {
        moveHorizontal = Input.GetAxis("Horizontal") * moveSpeed;
        moveVertical = Input.GetAxis("Vertical") * moveSpeed;
        rb.velocity = new Vector2 (moveHorizontal, moveVertical);
        
        Vector2 direction = new Vector2(moveHorizontal, moveVertical);
        playerAnimation.SetDirection(direction);
    }
}
