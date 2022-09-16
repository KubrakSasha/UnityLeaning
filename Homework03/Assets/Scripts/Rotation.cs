using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    Vector3 mPrevPos = Vector3.zero;
    Vector3 mPosDelta = Vector3.zero;
    void Update()        
    {
        if (Input.GetMouseButtonDown(0))
            mPrevPos = Input.mousePosition;
        if (Input.GetMouseButton(0))
        {
            mPosDelta = Input.mousePosition - mPrevPos;
            transform.rotation = Quaternion.Euler(0, mPosDelta.x, 0);
        }        
        if (Input.GetMouseButtonUp(0))
        {
            transform.rotation = Quaternion.identity;
        }
    }    
}