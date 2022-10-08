using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnObjects : MonoBehaviour

{
    [SerializeField] private GameObject[] prefabs;    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject obj = Instantiate(prefabs[Random.Range(0, prefabs.Length)], new Vector3(Random.Range(-4, 4), Random.Range(1, 9), Random.Range(-4, 4)), Quaternion.identity);           
            obj.GetComponent<Rigidbody>().velocity = RandomVector(0, 101);            
        }        
    }
    private Vector3 RandomVector(float min, float max)
    {
        var x = Random.Range(min, max);
        var y = Random.Range(min, max);
        var z = Random.Range(min, max);
        return new Vector3(x, y, z);

    }
}
