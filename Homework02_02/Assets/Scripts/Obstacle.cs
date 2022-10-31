using UnityEngine;

public class Obstacle : MonoBehaviour
{    
    Vector3 startPosition, endPosition;
    [SerializeField] float direction = 1f;
    float moveDistance = 30f;

    private void Start()
    {
        startPosition = transform.position;
        endPosition = startPosition + Vector3.right * moveDistance * direction;
    }
    void Update()
    {
        transform.position = Vector3.Lerp(startPosition, endPosition, Mathf.PingPong( Time.time,1));
    }
}