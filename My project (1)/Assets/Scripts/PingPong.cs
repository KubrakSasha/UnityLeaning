using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPong : MonoBehaviour
{    
    public float speed = 0.1f;
    public float pos = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0f, 0f, speed) * Time.deltaTime);
        float posX = transform.position.z;
        if (posX > pos)
        {
            speed = -speed;            
        }
        if (posX < 0 )
        {
            speed = -speed;
        }
    }
}