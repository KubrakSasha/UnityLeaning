using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class MovingPlatform : MonoBehaviour
{
    float speed = 3;
    Mesh mesh;
    // Start is called before the first frame update
    void Start()
    {
        //mesh = GetComponent<MeshFilter>().mesh;
        //mesh.vertices = CubeGenerator.GenerateVertices(10, 1, 10);
        //mesh.triangles = CubeGenerator.GenerateTriangles();
        //mesh.RecalculateNormals();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward * Time.deltaTime * speed;
        if (Input.GetMouseButtonDown(0))
            speed = 0;
    }
}
