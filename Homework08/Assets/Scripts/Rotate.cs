using UnityEngine;

public class Rotate : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();        
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           spriteRenderer.flipX = !spriteRenderer.flipX;
        }        
    }
}