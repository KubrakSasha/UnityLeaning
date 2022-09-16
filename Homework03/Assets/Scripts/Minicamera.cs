using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minicamera : MonoBehaviour
{
    void Start()
    {
        transform.eulerAngles = Vector3.one;
    }
    public void FaceCamera()
    {

        transform.eulerAngles = Vector3.zero;
    }
    public void UpCamera()
    {
        transform.eulerAngles = new Vector3(90, 0, 0);
    }
    public void DownCamera()
    {
        transform.eulerAngles = new Vector3(270, 180, 0);
    }

    public void LeftCamera()
    {
        transform.eulerAngles = new Vector3(0, 270, 0);
    }
}
   