using UnityEngine;

public class Obstacle : MonoBehaviour
{    
    Vector3 startPosition, endPosition;
    [SerializeField] float destination = 1f;
    private void Start()
    {
        startPosition = transform.position;
        endPosition = startPosition + new Vector3 (30 * destination, 0, 0);
    }
    void Update()
    {
        transform.position = Vector3.Lerp(startPosition, endPosition, Mathf.PingPong( Time.time,1));
    }
}