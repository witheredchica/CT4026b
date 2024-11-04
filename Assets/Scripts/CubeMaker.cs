using UnityEngine;

public class CubeMaker : MonoBehaviour
{
    Mesh mesh;

    [Range(0.1f, 10)] public float scale = 1;

    private void Awake() {
        mesh = new Mesh();
        mesh.name = "MyQuad";
        GetComponent<MeshFilter>().sharedMesh = mesh;
        Generate();
    }

    private void Update() => Generate();

    private void Generate() {
        Vector3[] vertices = new Vector3[] {
            //pos y
            new Vector3(1, 1, 1), //0
            new Vector3(-1, 1, 1), //1
            new Vector3(1, 1, -1), //2
            new Vector3(-1, 1, -1), //3

            //neg y
            new Vector3(1, -1, 1), //4
            new Vector3(-1, -1, 1), //5
            new Vector3(1, -1, -1), //6
            new Vector3(-1, -1, -1), //7

            //pos x
            new Vector3(1, 1, 1), //0
            new Vector3(1, -1, 1), //4
            new Vector3(1, 1, -1), //2
            new Vector3(1, -1, -1), //6

            //neg x
            new Vector3(-1, 1, 1), //1
            new Vector3(-1, -1, 1), //5
            new Vector3(-1, 1, -1), //3
            new Vector3(-1, -1, -1), //7

            //pos z
            new Vector3(1, 1, 1), //0
            new Vector3(-1, 1, 1), //1
            new Vector3(1, -1, 1), //4
            new Vector3(-1, -1, 1), //5

            //neg z
            new Vector3(1, 1, -1), //2
            new Vector3(-1, 1, -1), //3
            new Vector3(1, -1, -1), //6
            new Vector3(-1, -1, -1) //7
        };

        Vector3[] normals = new Vector3[] {
            new Vector3(0, 1, 0),
            new Vector3(0, 1, 0),
            new Vector3(0, 1, 0),
            new Vector3(0, 1, 0),

            new Vector3(0, -1, 0),
            new Vector3(0, -1, 0),
            new Vector3(0, -1, 0),
            new Vector3(0, -1, 0),

            new Vector3(1, 0, 0),
            new Vector3(1, 0, 0),
            new Vector3(1, 0, 0),
            new Vector3(1, 0, 0),

            new Vector3(-1, 0, 0),
            new Vector3(-1, 0, 0),
            new Vector3(-1, 0, 0),
            new Vector3(-1, 0, 0),

            new Vector3(0, 0, 1),
            new Vector3(0, 0, 1),
            new Vector3(0, 0, 1),
            new Vector3(0, 0, 1),

            new Vector3(0, 0, -1),
            new Vector3(0, 0, -1),
            new Vector3(0, 0, -1),
            new Vector3(0, 0, -1)
        };

        Vector2[] uvs = new Vector2[] {
            new Vector2(0, 1),
            new Vector2(0, 0),
            new Vector2(1, 1),
            new Vector2(1, 0),

            new Vector2(0, 1),
            new Vector2(0, 0),
            new Vector2(1, 1),
            new Vector2(1, 0),

            new Vector2(0, 1),
            new Vector2(0, 0),
            new Vector2(1, 1),
            new Vector2(1, 0),
            
            new Vector2(0, 1),
            new Vector2(0, 0),
            new Vector2(1, 1),
            new Vector2(1, 0),
            
            new Vector2(0, 1),
            new Vector2(0, 0),
            new Vector2(1, 1),
            new Vector2(1, 0),

            new Vector2(0, 1),
            new Vector2(0, 0),
            new Vector2(1, 1),
            new Vector2(1, 0)
        };

        int[] triangles = new int[] {
            /*
            0, 2, 3,
            0, 3, 1,

            7, 6, 4,
            5, 7, 4,

            6, 2, 0,
            4, 6, 0,

            1, 3, 7,
            1, 7, 5,

            5, 4, 0,
            1, 5, 0,

            2, 6, 7,
            2, 7, 3
            */
            
            0, 2, 3,
            0, 3, 1,

            7, 6, 4,
            5, 7, 4,

            11, 10, 8,
            9, 11, 8,

            12, 14, 15,
            12, 15, 13,

            19, 18, 16,
            17, 19, 16,

            20, 22, 23,
            20, 23, 21
            
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

/*
using UnityEngine;

public class CubeMaker : MonoBehaviour
{
    Mesh mesh;

    private void Awake() {
        mesh = new Mesh();
        mesh.name = "MyQuad";
        GetComponent<MeshFilter>().sharedMesh = mesh;
        Generate();
    }

    private void Generate() {
        Vector3[] vertices = new Vector3[] {
            //pos y
            new Vector3(1, 1, 1),
            new Vector3(-1, 1, 1),
            new Vector3(1, 1, -1),
            new Vector3(-1, 1, -1),

            //neg y
            new Vector3(1, -1, 1),
            new Vector3(-1, -1, 1),
            new Vector3(1, -1, -1),
            new Vector3(-1, -1, -1),

            //pos x
            new Vector3(1, 1, 1),
            new Vector3(1, -1, 1),
            new Vector3(1, 1, -1),
            new Vector3(1, -1, -1),

            //neg x
            new Vector3(-1, 1, 1),
            new Vector3(-1, -1, 1),
            new Vector3(-1, 1, -1),
            new Vector3(-1, -1, -1),

            //pos z
            new Vector3(1, 1, 1),
            new Vector3(-1, 1, 1),
            new Vector3(1, -1, 1),
            new Vector3(-1, -1, 1),

            //neg z
            new Vector3(1, 1, -1),
            new Vector3(-1, 1, -1),
            new Vector3(1, -1, -1),
            new Vector3(-1, -1, -1)
        };

        Vector3[] normals = new Vector3[] {
            new Vector3(0, 1, 0),
            new Vector3(0, 1, 0),
            new Vector3(0, 1, 0),
            new Vector3(0, 1, 0),

            new Vector3(0, -1, 0),
            new Vector3(0, -1, 0),
            new Vector3(0, -1, 0),
            new Vector3(0, -1, 0),

            new Vector3(1, 0, 0),
            new Vector3(1, 0, 0),
            new Vector3(1, 0, 0),
            new Vector3(1, 0, 0),

            new Vector3(-1, 0, 0),
            new Vector3(-1, 0, 0),
            new Vector3(-1, 0, 0),
            new Vector3(-1, 0, 0),

            new Vector3(0, 0, 1),
            new Vector3(0, 0, 1),
            new Vector3(0, 0, 1),
            new Vector3(0, 0, 1),

            new Vector3(0, 0, -1),
            new Vector3(0, 0, -1),
            new Vector3(0, 0, -1),
            new Vector3(0, 0, -1)
        };

        Vector2[] uvs = new Vector2[] {
            new Vector2(0, 1),
            new Vector2(0, 0),
            new Vector2(1, 1),
            new Vector2(1, 0),

            new Vector2(0, 1),
            new Vector2(0, 0),
            new Vector2(1, 1),
            new Vector2(1, 0),

            new Vector2(0, 1),
            new Vector2(0, 0),
            new Vector2(1, 1),
            new Vector2(1, 0),
            
            new Vector2(0, 1),
            new Vector2(0, 0),
            new Vector2(1, 1),
            new Vector2(1, 0),
            
            new Vector2(0, 1),
            new Vector2(0, 0),
            new Vector2(1, 1),
            new Vector2(1, 0),

            new Vector2(0, 1),
            new Vector2(0, 0),
            new Vector2(1, 1),
            new Vector2(1, 0)
        };

        int[] triangles = new int[] {//++, -+, +-, --
            0, 2, 3,    //++, +-, --
            0, 3, 1,    //++, --, -+

            7, 6, 4,    //--, +-, ++
            5, 7, 4,    //-+, --, ++

            11, 10, 8,  //--, +-, ++
            9, 11, 8,   //-+, --, ++

            12, 14, 15, //++, +-, --
            12, 15, 13, //++, --, -+

            19, 18, 16, //--, +-, ++
            17, 19, 16, //-+, --, ++

            20, 22, 23, //++, +-, --
            20, 23, 21  //++, --, -+
        };

        mesh.Clear();
        mesh.vertices = vertices;
        mesh.normals = normals;
        mesh.uv = uvs;
        mesh.triangles = triangles;
    }
}
*/