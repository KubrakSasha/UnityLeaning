using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPong : MonoBehaviour
{
    public Vector3 destination;
   
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(Vector3.zero, destination, Mathf.PingPong(Time.time, 1f));
       
    }
}