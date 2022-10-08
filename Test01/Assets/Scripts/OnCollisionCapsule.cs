using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionCapsule : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Walls"))
        {
            transform.localScale = RandomScale(0.1f, 5f);
            
            Debug.Log("BBBBBBBBB");
        }
    }
    private Vector3 RandomScale(float min, float max)
    {
        var x = Random.Range(min, max);        
        return new Vector3(x, x, x);
    }
}
