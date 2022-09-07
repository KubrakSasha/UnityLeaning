using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    //public GameObject rotator;
    public float rotateSpeed = 10f;
    public float directionX = 0f;
    public float directionY = 1f;
    public float directionZ = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(directionX, directionY, directionZ) * rotateSpeed * Time.deltaTime);
    }
}
