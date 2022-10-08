using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionSpere : MonoBehaviour
{
    MeshRenderer mr;
    private void Start()
    {
        mr = GetComponent<MeshRenderer>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Walls")) 
        {
            mr.material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);           
        }
    }
}
