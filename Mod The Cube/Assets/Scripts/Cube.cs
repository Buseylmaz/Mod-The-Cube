using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public Material[] materials;

    public Renderer rend;

    public Material currentMaterial;


    public float cubeSpeed = 10;


    void Update()
    {
        CubeColorChange();
        CubeMoveChange();
        CubeChangeScale();

    }


    void CubeColorChange()
    {
        currentMaterial = materials[Random.Range(0, materials.Length)];
        rend.material = currentMaterial;
    }


    void CubeMoveChange()
    {
        transform.position = new Vector3(Random.Range(1, 7), Random.Range(1, 7), Random.Range(1, 7));
    }

    void CubeChangeScale()
    {
        transform.localScale = new Vector3(Random.Range(1, 3), Random.Range(1, 4), Random.Range(1, 5));
    }
}
