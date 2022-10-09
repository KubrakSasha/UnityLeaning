using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    Animator animator;
    string[] idleDirections = { "Idle N", "Idle NW", "Idle W", "Idle SW", "Idle S", "Idle SE", "Idle E", "Idle NE" };    
    string[] runDirections = { "Run N", "Run NW", "Run W", "Run SW", "Run S", "Run SE", "Run E", "Run NE" };

    int lastDirection;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    public void SetDirection(Vector2 direction) 
    {
        string[] directionArray = null;
        if (direction.magnitude <0.01)
        {
            directionArray = idleDirections;
        }
        else
        {
            directionArray=runDirections;
            lastDirection = DirectionToIndex(direction);
        }
        animator.Play(directionArray[lastDirection]);    
    }

    private int DirectionToIndex(Vector2 direction)
    {
        Vector2 norDir = direction.normalized;
        float step = 360 / 8;
        float offset = step / 2;
        float angle = Vector2.SignedAngle(Vector2.up, norDir);
        angle += offset;
        if (angle<0)
        {
            angle += 360;
        }
        float stepCount = angle / step;
        return Mathf.FloorToInt(stepCount);
    }
}