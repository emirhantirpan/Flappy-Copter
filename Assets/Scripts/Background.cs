using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    private MeshRenderer _mr;
    public float animSpeed = 1f;

    private void Awake()
    {
        _mr = GetComponent<MeshRenderer>();
    }

    
    private void Update()
    {
        _mr.material.mainTextureOffset += new Vector2(animSpeed * Time.deltaTime, 0);
    }
}
