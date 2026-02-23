using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class GPTDie : MonoBehaviour
{
    void Start()
    {
        GenerateCube();
    }

    void GenerateCube()
    {
        Mesh mesh = new Mesh();
        mesh.name = "SubmeshCube";

        // 24 vertices (4 per face, so each face has unique normals/UVs)
        Vector3[] vertices = new Vector3[]
        {
            // Front
            new Vector3(-0.5f, -0.5f,  0.5f),
            new Vector3( 0.5f, -0.5f,  0.5f),
            new Vector3( 0.5f,  0.5f,  0.5f),
            new Vector3(-0.5f,  0.5f,  0.5f),

            // Back
            new Vector3( 0.5f, -0.5f, -0.5f),
            new Vector3(-0.5f, -0.5f, -0.5f),
            new Vector3(-0.5f,  0.5f, -0.5f),
            new Vector3( 0.5f,  0.5f, -0.5f),

            // Left
            new Vector3(-0.5f, -0.5f, -0.5f),
            new Vector3(-0.5f, -0.5f,  0.5f),
            new Vector3(-0.5f,  0.5f,  0.5f),
            new Vector3(-0.5f,  0.5f, -0.5f),

            // Right
            new Vector3( 0.5f, -0.5f,  0.5f),
            new Vector3( 0.5f, -0.5f, -0.5f),
            new Vector3( 0.5f,  0.5f, -0.5f),
            new Vector3( 0.5f,  0.5f,  0.5f),

            // Top
            new Vector3(-0.5f,  0.5f,  0.5f),
            new Vector3( 0.5f,  0.5f,  0.5f),
            new Vector3( 0.5f,  0.5f, -0.5f),
            new Vector3(-0.5f,  0.5f, -0.5f),

            // Bottom
            new Vector3(-0.5f, -0.5f, -0.5f),
            new Vector3( 0.5f, -0.5f, -0.5f),
            new Vector3( 0.5f, -0.5f,  0.5f),
            new Vector3(-0.5f, -0.5f,  0.5f)
        };

        // Standard quad UVs per face
        Vector2[] uvs = new Vector2[24];
        for (int i = 0; i < 6; i++)
        {
            int index = i * 4;
            uvs[index + 0] = new Vector2(0, 0);
            uvs[index + 1] = new Vector2(1, 0);
            uvs[index + 2] = new Vector2(1, 1);
            uvs[index + 3] = new Vector2(0, 1);
        }

        mesh.vertices = vertices;
        mesh.uv = uvs;

        // 6 submeshes (one per face)
        mesh.subMeshCount = 6;

        for (int i = 0; i < 6; i++)
        {
            int start = i * 4;
            int[] triangles = new int[]
            {
                start + 0, start + 2, start + 1,
                start + 0, start + 3, start + 2
            };

            mesh.SetTriangles(triangles, i);
        }

        mesh.RecalculateNormals();
        mesh.RecalculateBounds();

        GetComponent<MeshFilter>().mesh = mesh;
    }
}
