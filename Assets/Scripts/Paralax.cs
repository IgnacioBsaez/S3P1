using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour
{
    public float velocidad;
    Vector2 offset;
    public Material material;
    private void Update()
    {
        offset.x +=  Time.deltaTime * velocidad;
        material.SetTextureOffset("_MainTex",offset);
    }

}
