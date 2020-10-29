using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class MeshDeformer : MonoBehaviour
{
    Mesh mesh_to_deform;
    Vector3[] original_vertices, displaced_vertices;
    Vector3[] vertex_velocities;

    void Start()
    {
        mesh_to_deform     = GetComponent<MeshFilter>().mesh;
        original_vertices  = mesh_to_deform.vertices;               // Obtain original vertices at Start
        displaced_vertices = new Vector3[original_vertices.Length]  // Initialize displaced vertices from starting vertices
        for (int i = 0; i < original_vertices.Length; i++)
        {
            displaced_vertices[i] = original_vertices[i];
        }
        vertex_velocities = new Vector3 [original_vertices.Length]; // Intitialize velocities
    }

    void Update()
    {
        
    }
}
