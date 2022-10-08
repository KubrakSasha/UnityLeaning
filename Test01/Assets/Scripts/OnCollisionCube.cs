using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionCube : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Walls"))
        {
            transform.localScale = RandomVector(0.1f, 5f);
            transform.rotation = Quaternion.Euler(RandomVector(0,90));
            Debug.Log("BBBBBBBBB");
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
