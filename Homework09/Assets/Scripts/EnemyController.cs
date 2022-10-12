using UnityEngine;

public class EnemyController : MonoBehaviour
{
    Rigidbody2D rb;   
    [SerializeField] float speed;   
    Vector2 endPosition;
    Vector2 startPosition;   

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPosition = rb.transform.position;
        endPosition = startPosition + new Vector2(5, 0);
        EventManager.PlayerDied += OnDestroy;        
    }   
    void Update()
    {
        transform.position = Vector2.Lerp(startPosition, endPosition, Mathf.PingPong(Time.time,1));       
    }
    private void OnDestroy()
    {
        Destroy(gameObject);
        EventManager.PlayerDied -= OnDestroy;
    }
}