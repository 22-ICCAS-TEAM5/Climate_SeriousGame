using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    private MeshRenderer render;

    private float offset;
    private float speed;

    void Start()
    {
        render = GetComponent<MeshRenderer>();
        
    }
    void Update()
    {
        offset += Time.deltaTime * speed;
        render.material.mainTextureOffset = new Vector2(offset, 0);
        
    }
}