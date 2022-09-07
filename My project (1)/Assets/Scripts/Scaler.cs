using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{    
    public float timSec = 7;    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {        
        //transform.localScale = new Vector3(Mathf.Lerp(minimum, maximum, Time.time), Mathf.Lerp(minimum, maximum, Time.time), Mathf.Lerp(minimum, maximum, Time.time));
        if (Time.time < timSec)
        {
            transform.localScale = new Vector3(Time.time, Time.time, Time.time);
        }
    }
}
