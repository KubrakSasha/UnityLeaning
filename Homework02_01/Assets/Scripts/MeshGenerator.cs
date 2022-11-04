using UnityEngine;

//[RequireComponent(typeof(MeshFilter))]
//[RequireComponent (typeof(MeshRenderer))]
//public class MeshGenerator : MonoBehaviour
//{
//    Mesh mesh;
//    Vector3[] verticles;
//    int[] triangles;


//    void Start()
//    {        
//        mesh = GetComponent<MeshFilter>().mesh;
//        CreateShape();
//        UpdateMesh();
//    }

//    void CreateShape() 
//    {
//        verticles = new Vector3[]
//        {
//            new Vector3(-1,1,-1),//0
//            new Vector3(-1,1,1),//1
//            new Vector3(1,1,1),//2
//            new Vector3(1,1,-1),//3
//            new Vector3(-1,-1,-1),//4
//            new Vector3(-1,-1,1),//5
//            new Vector3(1,-1,1),//6
//            new Vector3(1,-1,-1)//7      
//        };
//        triangles = new int[] 
//        {
//             0,1,3, 3,1,2,
//            3,2,6, 7,3,6,
//            0,5,1, 0,4,5,
//            1,6,2, 1,5,6,
//            0,3,7, 0,7,4,
//            5,7,6, 4,7,5
//        };
//    }
//    void UpdateMesh() 
//    { 
//        mesh.Clear();
//        mesh.vertices = verticles;
//        mesh.triangles = triangles;
//        mesh.RecalculateNormals();
//    }
    //Vector3[] GenerateVertices() 
    //{

    //    return new Vector3[]
    //    {
    //        new Vector3(-1,1,-1),//0
    //        new Vector3(-1,1,1),//1
    //        new Vector3(1,1,1),//2
    //        new Vector3(1,1,-1),//3
    //        new Vector3(-1,-1,-1),//4
    //        new Vector3(-1,-1,1),//5
    //        new Vector3(1,-1,1),//6
    //        new Vector3(1,-1,-1)//7         
    //    };
    //}
    //int[] GenerateTriangles() 
    //{
    //    return new int[]{ 
    //        0,1,3, 3,1,2,
    //        3,2,6, 7,3,6,
    //        0,5,1, 0,4,5,
    //        1,6,2, 1,5,6,
    //        0,3,7, 0,7,4,
    //        5,7,6, 4,7,5};
    //}
//}
