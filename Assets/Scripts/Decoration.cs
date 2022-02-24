using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : ScriptableObject
{
    public Vector3 position;
    [Range(0,2)] // limita entre 0 y 2
    public int modelTree;
}

public class Decoration : MonoBehaviour
{
    public Material material;
    public Mesh[] meshes;

    [SerializeField]
    private Tree[] leftTrees;
    [SerializeField]
    private Tree[] rightTrees;

    private float y1 = 0;//-4.9f;
    private float y2 = 4;//-4.5f;

    private float leftX1 = -28f;
    private float leftX2 = -6f;

    private float rightX1 = 8f;
    private float rightX2 = 33f;

    private float z1 = 0f;
    private float z2 = 120f;

    /*private float distanceZ1 = 7.5f;
    private float distanceZ2 = 12f;*/

    private void Start()
    {
        for (int i = 0; i < leftTrees.Length; i++)
        {
            leftTrees[i] = ScriptableObject.CreateInstance<Tree>();
            rightTrees[i] = ScriptableObject.CreateInstance<Tree>();

            //izquierda
            leftTrees[i].position = new Vector3(Random.Range(leftX1, leftX2), 5, Random.Range(z1, z2)); // 5 es del árbol
            leftTrees[i].modelTree = Random.Range(0, 3);
            //derecha
            rightTrees[i].position = new Vector3(Random.Range(rightX1, rightX2), 5, Random.Range(z1, z2));
            rightTrees[i].modelTree = Random.Range(0, 3);

            RaycastHit hit;

            if (Physics.Raycast(leftTrees[i].position, Vector3.down, out hit, 12))
            {
                leftTrees[i].position.y -= hit.distance;
            }
            if (Physics.Raycast(rightTrees[i].position, Vector3.down, out hit, 12))
            {
                rightTrees[i].position.y -= hit.distance;
            }
        }
    }

    void Update()
    {
        RenderDecoration();
    }

    void RenderDecoration()
    {
        for (int i = 0; i < leftTrees.Length; i++)
        {
            //izquierda
            Graphics.DrawMesh(meshes[leftTrees[i].modelTree], leftTrees[i].position, Quaternion.Euler(0, 0, 0), material, gameObject.layer);
            //derecha
            Graphics.DrawMesh(meshes[rightTrees[i].modelTree], rightTrees[i].position, Quaternion.Euler(0, 0, 0), material, gameObject.layer);
        }
    }
}