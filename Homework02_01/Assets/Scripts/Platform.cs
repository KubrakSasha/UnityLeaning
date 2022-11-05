using UnityEngine;

public static class Platform 
{  
    public static GameObject CreatPlatform(float length, float height, float width) 
    {
        GameObject platform = new GameObject("platform",typeof(MeshFilter),typeof(MeshRenderer));
        Mesh mesh = platform.GetComponent<MeshFilter>().mesh = new Mesh();
        mesh.vertices = GenerateVertices(length, height, width);
        mesh.triangles = GenerateTriangles();
        mesh.RecalculateNormals();
        Material material = platform.GetComponent<MeshRenderer>().material;
        material.color = GetRandomColor();
        return platform;
    }
    public static Vector3[] GenerateVertices(float length, float height, float width)
    {
        return new Vector3[]
        {
            new Vector3(-length/2,height/2,-width/2),//0
            new Vector3(-length / 2,height / 2,width/2),//1
            new Vector3(length/2,height / 2,width / 2),//2
            new Vector3(length/2,height / 2,-width / 2),//3
            new Vector3(-length/2,-height / 2,-width / 2),//4
            new Vector3(-length/2,-height / 2,width / 2),//5
            new Vector3(length/2,-height/2,width/2),//6
            new Vector3(length/2,-height/2,-width/2)//7         
        };
    }
    public static int[] GenerateTriangles()
    {
        return new int[]{
            0,1,3, 3,1,2,
            3,2,6, 7,3,6,
            0,5,1, 0,4,5,
            1,6,2, 1,5,6,
            0,3,7, 0,7,4,
            5,7,6, 4,7,5};
    }
    public static Color GetRandomColor()
    {
        return new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }
}
