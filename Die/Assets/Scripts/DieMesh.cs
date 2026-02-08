using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieMesh : MonoBehaviour
{
    private Vector3[] vertices = new Vector3[8];
    private Vector2[] uv = new Vector2[8];
    // private Vector2[] uv1 = new Vector2[4];
    // private Vector2[] uv2 = new Vector2[4];
    // private Vector2[] uv3 = new Vector2[4];
    // private Vector2[] uv4 = new Vector2[4];
    // private Vector2[] uv5 = new Vector2[4];
    // private Vector2[] uv6 = new Vector2[4];
    private int[] triangles = new int[36];


    private GameObject meshObject;
    private Mesh mesh;

    void Start()
    {
        GenerateMeshData();

        mesh = new Mesh();
        mesh.name = "Custom mesh";

        meshObject = new GameObject("Mesh object", typeof(MeshRenderer), typeof(MeshFilter));

        meshObject.GetComponent<MeshFilter>().mesh = mesh;

        mesh.vertices = vertices;
        mesh.uv = uv;
        mesh.triangles = triangles;
    }

    private void GenerateMeshData() {

        vertices[0] = new Vector3(0, 0, 0);
        vertices[1] = new Vector3(0, 1, 0);
        vertices[2] = new Vector3(1, 1, 0);
        vertices[3] = new Vector3(1, 0, 0);
        vertices[4] = new Vector3(0, 0, 1);
        vertices[5] = new Vector3(0, 1, 1);
        vertices[6] = new Vector3(1, 1, 1);
        vertices[7] = new Vector3(1, 0, 1);

        triangles[0] = 1;
        triangles[1] = 2;
        triangles[2] = 3;

        triangles[3] = 1;
        triangles[4] = 3;
        triangles[5] = 0;

        triangles[6] = 2;
        triangles[7] = 6;
        triangles[8] = 7;

        triangles[9] = 2;
        triangles[10] = 7;
        triangles[11] = 3;

        triangles[12] = 6;
        triangles[13] = 5;
        triangles[14] = 4;

        triangles[15] = 6;
        triangles[16] = 4;
        triangles[17] = 7;

        triangles[18] = 2;
        triangles[19] = 1;
        triangles[20] = 5;

        triangles[21] = 2;
        triangles[22] = 5;
        triangles[23] = 6;

        triangles[24] = 7;
        triangles[25] = 4;
        triangles[26] = 0;

        triangles[27] = 7;
        triangles[28] = 0;
        triangles[29] = 3;

        triangles[30] = 5;
        triangles[31] = 1;
        triangles[32] = 0;

        triangles[33] = 5;
        triangles[34] = 0;
        triangles[35] = 4;

        uv[0] = new Vector2(0, 1);
        uv[1] = new Vector2(1, 1);
        uv[2] = new Vector2(1, 0);
        uv[3] = new Vector2(0, 0);

    }

    void Update()
    {
        
    }
}
