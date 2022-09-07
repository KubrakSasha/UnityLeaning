using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Teleport : MonoBehaviour
{    
    private float nextTime = 0.0f;
    public float sec = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextTime)
        {
            nextTime += sec;
            transform.position = new Vector3(Random.RandomRange(15, 30), (0), Random.RandomRange(0, 10));
        }
    }    
}
