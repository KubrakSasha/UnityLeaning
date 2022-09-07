using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inClass : MonoBehaviour
{
    public GameObject[] prefabs;
    private GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (prefabs == null)
            {
                Debug.LogError("Array is NULL!!!");
                return;
            }
            if (obj != null)
            {
                Destroy(obj);
            }

            for (int i = 0; i < prefabs.Length; i++)
            {
                obj = Instantiate(prefabs[Random.Range(0, prefabs.Length)], new Vector3 (Random.Range(0, 6),Random.Range(0, 6), Random.Range(0, 0)), Quaternion.identity);
                return;                
            }
        }   
    }
}