using UnityEngine;

public class TetrahedronMaker : MonoBehaviour
{
    //this isnt a tetrahedron oops

    Mesh mesh;

    [Range(0.1f, 10)] public float scale = 1;

    private void Awake() {
        mesh = new Mesh();
        mesh.name = "MyTetrahedron";
        GetComponent<MeshFilter>().sharedMesh = mesh;
        Generate();
    }

    private void Update() => Generate();

    private void Generate() {
        Vector3[] vertices = new Vector3[] {
            new Vector3(0, -1, 1),
            new Vector3(0, -1, -1),
            new Vector3(1, -1, 0),
            new Vector3(-1, -1, 0),

            new Vector3(0, -1, 1), //0
            new Vector3(1, -1, 0), //2
            new Vector3(0, 1, 0), //4

            new Vector3(0, -1, 1), //0
            new Vector3(-1, -1, 0), //3
            new Vector3(0, 1, 0), //4

            new Vector3(0, -1, -1), //1
            new Vector3(-1, -1, 0), //3
            new Vector3(0, 1, 0), //4

            new Vector3(0, -1, -1), //1
            new Vector3(1, -1, 0), //2
            new Vector3(0, 1, 0) //4
        };

        Vector3[] normals = new Vector3[] {
            new Vector3(0, -1, 0),
            new Vector3(0, -1, 0),
            new Vector3(0, -1, 0),
            new Vector3(0, -1, 0),

            new Vector3(1, 1, 1),
            new Vector3(1, 1, 1),
            new Vector3(1, 1, 1), 
            
            new Vector3(-1, 1, 1),
            new Vector3(-1, 1, 1),
            new Vector3(-1, 1, 1),
            
            new Vector3(-1, 1, -1),
            new Vector3(-1, 1, -1),
            new Vector3(-1, 1, -1),
            
            new Vector3(1, 1, -1),
            new Vector3(1, 1, -1),
            new Vector3(1, 1, -1)
        };

        Vector2[] uvs = new Vector2[] {
            new Vector2(0, 1),
            new Vector2(0, 0),
            new Vector2(1, 1),
            new Vector2(1, 0),

            new Vector2(0, 1),
            new Vector2(0, 0),
            new Vector2(1, 0),
            
            new Vector2(0, 1),
            new Vector2(0, 0),
            new Vector2(1, 0),
            
            new Vector2(0, 1),
            new Vector2(0, 0),
            new Vector2(1, 0),
            
            new Vector2(0, 1),
            new Vector2(0, 0),
            new Vector2(1, 0)
        };

        int[] triangles = new int[] {
            0, 3, 2,
            1, 2, 3,

            5, 6, 4,

            7, 9, 8,

            12, 10, 11,

            13, 15, 14
        };

        for (int i = 0; i < vertices.Length; i++) {
            vertices[i] *= scale;
        }

        mesh.Clear();
        mesh.vertices = vertices;
        mesh.normals = normals;
        mesh.uv = uvs;
        mesh.triangles = triangles;
    }
}
