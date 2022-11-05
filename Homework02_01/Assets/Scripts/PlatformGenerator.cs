using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformGenerator : MonoBehaviour
{

    Camera cam;
    List<GameObject> platforms = new List<GameObject>();
    Vector3 platformGeneratorStarPosition = new Vector3(0, 0, -2);
    float speed = 0.5f;
    GameObject currentPlatform;
    GameObject lastPlatform;
    int level = 0;
    float offset;
    float zSize;    

    private void Start()
    {        
        var startPlatform = Platform.CreatPlatform(1,1,1);
        lastPlatform = startPlatform;
        CreatFirstPlatform();
        cam = Camera.main;
    }

    void Update()
    {        
        if (Input.GetMouseButtonDown(1))            
        {
            StopAndCutPlatform();
            if (Mathf.Abs(offset) >= lastPlatform.transform.localScale.z)
            {
                SceneManager.LoadScene(0);
            }
            lastPlatform = currentPlatform;
            CreatNewPlatform(zSize);
            MoveCamera();
        }        
        currentPlatform.transform.position += Vector3.forward * Time.deltaTime* speed;        
    }

    private void CreatNewPlatform(float z)
    {
        GameObject plat = Platform.CreatPlatform(1, 0.1f, 1);
        plat.transform.localScale = new Vector3(plat.transform.localScale.x, transform.localScale.y , z);       
        platforms.Add(plat);
        currentPlatform = platforms[level];
        transform.position = platformGeneratorStarPosition + new Vector3(0,lastPlatform.transform.position.y,0) + new Vector3 (0, 0.1f, 0);
        currentPlatform.transform.position = transform.position;
    }

    private void StopAndCutPlatform()
    {
        int direction = 1;
        direction = lastPlatform.transform.position.z > currentPlatform.transform.position.z ? 1 : -1;

        offset = lastPlatform.transform.position.z - currentPlatform.transform.position.z;    
        zSize = currentPlatform.transform.localScale.z - Mathf.Abs(offset);
        
        currentPlatform.transform.localScale = new Vector3(currentPlatform.transform.localScale.x, transform.localScale.y, zSize);       
        currentPlatform.transform.position = new Vector3(currentPlatform.transform.position.x, currentPlatform.transform.position.y, currentPlatform.transform.position.z +  direction * Mathf.Abs(offset / 2));

        GameObject fallingPlatform = Platform.CreatPlatform(1,0.1f,1);
        fallingPlatform.transform.localScale = new Vector3(fallingPlatform.transform.localScale.x, fallingPlatform.transform.localScale.y, offset);
        fallingPlatform.transform.position = new Vector3(currentPlatform.transform.position.x, currentPlatform.transform.position.y, currentPlatform.transform.position.z - direction * (zSize/2 + Mathf.Abs(offset / 2)));
        fallingPlatform.AddComponent<Rigidbody>().useGravity = true;
        
        speed++;
        level++;        
    }
    private void CreatFirstPlatform()
    {
        GameObject plat = Platform.CreatPlatform(1, 0.1f, 1);        
        platforms.Add(plat);
        currentPlatform = platforms[level];
        transform.position = platformGeneratorStarPosition + new Vector3(0,0.55f,0);
        currentPlatform.transform.position = transform.position;
    }
    void MoveCamera() 
    {
        cam.transform.position += new Vector3(0, 0.05f, 0);
    }

}
